using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using time_of_your_life.Entity;
using time_of_your_life.Services;

namespace time.Controllers;

[ApiController]
[Route("[controller]")]
public class ClockController : ControllerBase
{
    private static List<ClockProps> _presets = new List<ClockProps>(){ new() };

    private readonly ILogger<ClockController> _logger;

    private readonly TimerService _timerService;
    public ClockController(ILogger<ClockController> logger, TimerService timerService)
    {
        _logger = logger;
        _timerService = timerService;
    }

    [HttpGet, Route("presets")]
    public IEnumerable<ClockProps> GetPresets()
    {
        return _presets.ToArray();
    }

    [HttpPost("presets")]
    public ClockProps AddPreset([FromBody]ClockProps preset)
    {
        preset.Id = Guid.NewGuid();
        _presets.Add(preset);
        return preset;
    }


    [HttpPost("createTimer")]
    public async Task<IActionResult> AddTimer(TimerEntity timerEntity)
    {
        string message = "";
        if (ModelState.IsValid)
        {
            await _timerService.AddTimer(timerEntity);
            message="added";
            return Ok(new { Status = 200, Message = message });
        }
        return BadRequest(new { Status = 400, Message = "Invalid model state. Please check the input data." });
    }
}
