using Microsoft.Extensions.DependencyInjection;
using TripSorter;
using TripSorter.BLL;
using TripSorter.Interface;
using TripSorter.Services;


/**/
namespace TripSorter;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}
/**/
/*
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ITransportationService, TransportationService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//service.BuildServiceProvider().GetService<ITransportationService, Transportation>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run(); */

