using API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class CatFactController : ControllerBase
{
    private readonly ICatFactService _catFactService;
    private readonly ILoggingService _loggingService;

    public CatFactController(ICatFactService catFactService, ILoggingService loggingService)
    {
        _catFactService = catFactService;
        _loggingService = loggingService;
    }

    [HttpGet("log")]
    public async Task<IActionResult> LogFactAsync()
    {
        var fact = await _catFactService.GetCatFactAsync();

        if (fact == null)
        {
            return StatusCode(503, "Failed to retrieve data from API.");
        }

        try
        {
            await _loggingService.LogToFileAsync(fact);
            return Ok(fact);
        }
        catch (IOException ex)
        {
            return StatusCode(500, $"File saving error:{ex.Message}");
        }
    }
}

