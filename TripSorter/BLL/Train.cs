using System;
using TripSorter.Model;
using TripSorter.Untilities;
using static TripSorter.Untilities.Enums;

namespace TripSorter.BLL;

public class Train : Transportation
{
    private string _transportationType;
    private string _departure;
    private string _arrival;
    private string _transportationNumber;
    private string _gate;
    private string _seat;
    private string _baggage;

    public Train(Boarding boarding)
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
        get { return _departure; }
        set { _departure = value; }
    }

    public override string arrival
    {
        get { return _arrival; }
        set { _arrival = value; }
    }

    public override string? transportationNumber
    {
        get { return _transportationNumber; }
        set { _transportationNumber = value!; }
    }

    public override string? seat
    {

        get { return _seat; }
        set { _seat = value!; }
    }

    public override string? gate
    {
        get { return _gate; }
        set { _gate = value!; }
    }

    public override string? baggage
    {
        get { return _baggage; }
        set { _baggage = value!; }
    }

    public override string? message { get => GetMessage(); }

    public new string GetMessage()
    {
        return string.Format(TripConstants.MESSAGE_TRAIN_BOARDING, transportationNumber, departure, arrival, seat);
    }
}
