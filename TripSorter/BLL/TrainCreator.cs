using System;
using TripSorter.Model;

namespace TripSorter.BLL;

public class TrainCreator : TransportationFactory
{
    public override Transportation GetTransportation(Boarding boarding)
    {
        return new Train(boarding);
    }
}

