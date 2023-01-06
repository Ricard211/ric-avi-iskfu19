using Microsoft.AspNetCore.Mvc;
using ric_avi_iskfu19.Models;
using ric_avi_iskfu19.Services;


[ApiController]
[Route("api/products")]
public class HelmetController : ControllerBase
{
    private readonly ILogger<HelmetController> _logger;
    private readonly HelmetService _helmetService;


    public HelmetController(
        ILogger<HelmetController> logger, HelmetService helmetService)
    {
        _logger = logger;
        _helmetService = helmetService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Helmet>>> GetHelmets()
    {
        var helmets = await _helmetService.GetHelmet();
        return Ok(helmets);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<object>> GetHelmetId(int id)
    {
        var helmet = await _helmetService.GetHelmetId(id); 
        return Ok(helmet);
    }

    [HttpPost]
    public async Task<ActionResult<object>> CreateHelmet(HelmetMaker helmetMaker)
    {
        var helmet = await _helmetService.Create(helmetMaker);
        return Created(helmet);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<object>> UpdateHelmet(int id, [FromBody] Helmet helmet)
    {
         var helmets = await _helmetService.ChangeHelmets(id, helmet);
        return Ok(helmets);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<object>> DeleteHelmet(int id)
    {
        
        var helmet = await _helmetService.DeleteHelmet(id); 
        return Ok(helmet);
    }

    private ObjectResult Created(object value)
    {
        return StatusCode(201, value);
    }
}