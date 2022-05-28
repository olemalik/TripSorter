using System;
using TripSorter.Model;

namespace TripSorter.BLL;

public abstract class TransportationFactory
{
	public abstract Transportation GetTransportation(Boarding boarding);
}