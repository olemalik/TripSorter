using Microsoft.AspNetCore.Mvc;
using TripSorter.Interface;
using TripSorter.BLL;

namespace TripSorter.Controllers;

[ApiController]
[Route("[controller]")]
public class TransportController : ControllerBase
{
    private readonly ILogger<TransportController> _logger; 
    private readonly ITransportationService _transportationService;

    public TransportController(ILogger<TransportController> logger, ITransportationService transportService)
    {
        _logger = logger; 
        _transportationService = transportService;
    }

    [HttpGet(Name = "GeTransport")]
    public async Task<List<Transportation>> Get()
    {
        List<Transportation> result = await _transportationService.GetTransportations();
        
        return result;
    }
}



