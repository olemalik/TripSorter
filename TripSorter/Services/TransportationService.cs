using System;
using TripSorter.BLL;
using TripSorter.Interface;
using TripSorter.Model;
using TripSorter.Untilities;

namespace TripSorter.Services;

public class TransportationService : ITransportationService
{
    private string _projectRootPath;

    public TransportationService(IWebHostEnvironment hostingEnvironment)
    {
        //"/Users/malikahmed/Projects/TripSorter/TripSorter/TripSorter/"
        _projectRootPath = hostingEnvironment.ContentRootPath;
    }

    public async Task<List<Transportation>> GetTransportations()
    {
        List<Transportation> transportation = new List<Transportation>();

        var boardings = await JsonFileReader.ReadAsync<List<Boarding>>(@$"{_projectRootPath}//Data//boarding.cards.json");

        var cdc = new Sorter(boardings);
        boardings = cdc.Bubble();

        foreach (var item in boardings)
        {
            switch (item.TransportationType)
            {
                case "Bus":
                      transportation.Add(new BusCreator().GetTransportation(item));
                    break;
                case "Train":
                    transportation.Add(new TrainCreator().GetTransportation(item));
                    break;
                case "Plane":
                    transportation.Add(new PlaneCreator().GetTransportation(item));
                    break;
                default:
                    break;
            }
        }
        return transportation;
    }

   
}

