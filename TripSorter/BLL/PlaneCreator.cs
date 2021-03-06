using System;
using TripSorter.Model;
using TripSorter.Untilities;
using static TripSorter.Untilities.Enums;

namespace TripSorter.BLL;

public class Plane : Transportation
{
    private string _transportationType;
    private string _departure;
    private string _arrival;
    protected string _transportationNumber;
    private string _gate;
    private string _seat;
    private string _baggage;

    public Plane(Boarding boarding)
    {
        _transportationType = boarding.TransportationType;
        _departure = boarding.Departure;
        _arrival = boarding.Arrival;
        _transportationNumber = boarding.TransportationNumber;
        _gate = boarding.Gate!;
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
        string message = string.Format(TripConstants.MESSAGE_PLANE_BOARDING, departure, transportationNumber, arrival, gate, seat);

        if (!string.IsNullOrEmpty(baggage))
        {
            message += string.Format(TripConstants.MESSAGE_PLANE_BOARDING_WITH_BAGGAGE, baggage);
            return message;
        }
        return string.Format(TripConstants.MESSAGE_PLANE_BOARDING_WITHOUT_BAGGAGE, message);
    }
}
