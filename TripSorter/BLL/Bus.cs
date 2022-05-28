using System;
using TripSorter.Model;
using TripSorter.Untilities;
using static TripSorter.Untilities.Enums;

namespace TripSorter.BLL;

public class Bus : Transportation
{
    private string _transportationType;
    private string _departure;
    private string _arrival;
    private string _transportationNumber;
    private string _gate;
    private string _seat;
    private string _baggage;

    public Bus(Boarding boarding)
    {
        _transportationType = boarding.TransportationType;
        _departure = boarding.Departure;
        _arrival = boarding.Arrival;
        _transportationNumber = boarding.TransportationNumber;
        _gate = boarding.Seat!;
        _seat = boarding.Seat!;
        _baggage = boarding.Baggage!;
    }

    public override string transportationType
    {
        get { return _transportationType; }
    }

    public override string departure
    {
        get => _departure;
        set => _departure = value!;
    }

    public override string arrival
    {
        get => _arrival;
        set => _arrival = value;
    }

    public override string? transportationNumber
    {
        get => _transportationNumber;
        set => _transportationNumber = value!;
    }

    public override string? seat
    {
        get => _seat;
        set => _seat = value!;
    }

    public override string? gate
    {
        get => _gate;
        set => _gate = value!;
    }

    public override string? baggage
    {
        get => _baggage; 
        set => _baggage = value!; 
    }

    public override string? message { get => GetMessage(); }

    private string GetMessage()
    {
        return string.Format(TripConstants.MESSAGE_BUS_BOARDING,
                departure, arrival);
    }
}
