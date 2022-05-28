using System;
using TripSorter.Model;

namespace TripSorter.BLL;

public class BusCreator : TransportationFactory
{
    public override Transportation GetTransportation(Boarding boarding)
    {
        return new Bus(boarding);
    }
}


