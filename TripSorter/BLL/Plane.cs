using System;
using TripSorter.Model;

namespace TripSorter.BLL;

public class PlaneCreator : TransportationFactory
{
    public override Transportation GetTransportation(Boarding boarding)
    {
        return new Plane(boarding);
    }
}


