using System;
namespace TripSorter.Interface
{
	public class TransportationDto
	{

        public string transportationType { get; set; } = null!;
        public string departure { get; set; } = null!;
        public string arrival { get; set; } = null!;
        public string? transportationNumber { get; set; }
        public string? seat { get; set; }
        public string? gate { get; set; }
        public string? baggage { get; set; }
        public string? message { get; set; }
    }
}

