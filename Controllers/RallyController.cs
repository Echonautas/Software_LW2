using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/Rally")]
public class RallyController : ControllerBase
{
    private readonly ILogger<RallyController> _logger;
    private readonly RallyService _RallyService;


    public RallyController(
        ILogger<RallyController> logger,
        RallyService RallyService)
    {
        _logger = logger;
        _RallyService = RallyService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Rally>>> GetRally()
    {
        var rallys = await _RallyService.GetRally();
        return Ok(rallys);
    }

    [HttpPost]
    public async Task<ActionResult<object>> CreateRally(RallyDrivers rallyDrivers)
    {
        var rally = await _RallyService.Create(rallyDrivers);
        return Created(rally);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<object>> GetRallyID(int id)
    {
        var rallys = await _RallyService.GetRallyID(id);
        return Ok(rallys);
    }



    [HttpPut("{id}")]
    public async Task<ActionResult<object>> UpdateRally(int id, [FromBody]Rally rally)
    {
        var rallys = await _RallyService.EditData(id, rally);
        return Ok(rally);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<object>> DeleteRally(int id)
    {
        var rallys = await _RallyService.Delete(id);
        return Ok(rallys);
    }


    private ObjectResult Created(object value)
    {
        return StatusCode(201, value);
    }
}
