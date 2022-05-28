using System;
using TripSorter.Interface;
using TripSorter.Model;
using static TripSorter.Untilities.Enums;

namespace TripSorter.BLL;

public abstract class Transportation// : TransportationInterface
{
    public abstract string transportationType { get; }
    public abstract string departure { get; set; }
    public abstract string arrival { get; set; }
    public abstract string? transportationNumber { get; set; }
    public abstract string? seat { get; set; }
    public abstract string? gate { get; set; }
    public abstract string? baggage { get; set; }
    public abstract string? message { get; }

   
    /*
    public string GetMessage()
    {
        return "";
    }*/


}
