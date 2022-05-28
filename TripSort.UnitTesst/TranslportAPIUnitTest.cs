using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using TripSorter;
using TripSorter.Interface;
using TripSorter.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TripSorter.BLL;
using TripSorter.Untilities;

namespace TripSort.UnitTesst;

public class TranslportAPIUnitTest : IDisposable
{
    private readonly TestServer _server;
    private readonly HttpClient _client;
    private readonly string _tripSortApiUrl = "https://localhost:7153/transport";

    public TranslportAPIUnitTest()
    {
        // Arrange
        var webBuilder = new WebHostBuilder();

        //Initiazinzing the TripSort project Startup, for TestServer
        webBuilder.UseStartup<Startup>();
        webBuilder.ConfigureServices(s => s.AddSingleton<ITransportationService,
            TransportationService>());

        // Initializing TestServer
        _server = new TestServer(webBuilder);

        // Creating HttpClient
        _client = _server.CreateClient();
    }

    public void Dispose()
    {
        //On Success or fail of the test need dispose the constructor initializations
        _server.Dispose();
        _client.Dispose();
    }

    [Fact]
    public async Task GetTransportation200Test()
    {
        // Act
        var response = await _client.GetAsync(_tripSortApiUrl);

        // Assert
        Assert.NotNull(response);
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        var responseString = await response.Content.ReadAsStringAsync();
        Assert.NotNull(responseString);

        var result = JsonConvert.DeserializeObject<List<TransportationDto>>(
            responseString);
        Assert.NotNull(result);
        Assert.Equal(4, result.Count);

        // Assert - Train
        var firstBoarding = result.Where(w => w.departure == "Madrid"
                             && w.arrival == "Barcelona").FirstOrDefault();
        Assert.NotNull(firstBoarding);
        Assert.Equal("Train", firstBoarding.transportationType);
        Assert.Equal("78A", firstBoarding.transportationNumber);
        Assert.Equal("45B", firstBoarding.seat);
        string trainMessage = string.Format(TripConstants.MESSAGE_TRAIN_BOARDING,
            firstBoarding.transportationNumber, firstBoarding.departure,
            firstBoarding.arrival, firstBoarding.seat);
        Assert.Equal(trainMessage, firstBoarding.message);

        // Assert - Bus
        var busBoardings = result.Where(w => w.transportationType == "Bus")
                            .ToList();
        Assert.NotNull(busBoardings);
        Assert.Single(busBoardings);
        var busBoarding = busBoardings.First();
        Assert.Equal("Barcelona", busBoarding.departure);
        Assert.Equal("Gerona Airport", busBoarding.arrival);
        Assert.Null(busBoarding.seat);
        string busMessage = string.Format(TripConstants.MESSAGE_BUS_BOARDING,
                            busBoarding.departure, busBoarding.arrival);
        Assert.Equal(busMessage, busBoarding.message);

        // Assert - Plane
        var planBoardings = result.Where(w => w.transportationType == "Plane")
                            .ToList();
        Assert.NotNull(planBoardings);
        Assert.Equal(2, planBoardings.Count);

        var planBoarding = planBoardings
                            .Where(t => t.transportationNumber == "SK455")
                            .First();
        Assert.NotNull(planBoarding);
        Assert.Equal("Gerona Airport", planBoarding.departure);
        Assert.Equal("Stockholm", planBoarding.arrival);
        Assert.Equal("334", planBoarding.baggage);

        string planeMessage = string.Format(TripConstants.MESSAGE_PLANE_BOARDING,
            planBoarding.departure, planBoarding.transportationNumber,
            planBoarding.arrival, planBoarding.gate, planBoarding.seat);
        Assert.Contains(planeMessage, planBoarding.message);
    }

    [Theory]
    [InlineData(1)]
    public async Task GetTransportation404Test(int id)
    {
        // Act
        var response = await _client.GetAsync($"{_tripSortApiUrl}/{id}");

        // Assert
        Assert.NotNull(response);
        Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);

        var responseString = await response.Content.ReadAsStringAsync();
        Assert.Null(responseString);
    }
}
