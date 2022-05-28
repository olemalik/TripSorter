using System;
using static TripSorter.Untilities.Enums;

namespace TripSorter.Model
{
	public class Boarding
    {
        public string Departure { get; set; } = string.Empty;
        public string Arrival { get; set; } = string.Empty;
        public string TransportationType { get; set; } = string.Empty;
        public string TransportationNumber { get; set; } = string.Empty;
        public string? Seat { get; set; }
        public string? Gate { get; set; }
        public string? Baggage { get; set; }
    }
}

