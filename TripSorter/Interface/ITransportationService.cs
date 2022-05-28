using System;
using TripSorter.BLL;

namespace TripSorter.Interface;

public interface ITransportationService
{
	Task<List<Transportation>> GetTransportations();
	/*string GetDeparture();
	string GetArrival();
	string GetMessage();*/
}
