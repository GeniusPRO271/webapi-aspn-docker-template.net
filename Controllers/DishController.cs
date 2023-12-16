using BackEndProject.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndProject.Controllers.WeatherController;

[ApiController]
[Route("api/dish")]
public class DishController : ControllerBase
{

    private readonly ILogger<AuthController> _logger;
    private readonly APIDBcontext _context;

    public DishController(ILogger<AuthController> logger, APIDBcontext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GET_DISH([FromQuery] Category[] _category, bool vegetarian)
    {
        try
        {
            return Ok("OK_RESPONSE_GET_DISH");
        }
        catch (InvalidOperationException ex)
        {
            // Write logs
        }
        catch (Exception ex)
        {
            return StatusCode(500);
        }

        return BadRequest();
    }
     [HttpGet]
     [Route("{id}")]
    public async Task<IActionResult> GET_DISH_INFO_FROM_ID(Guid id)
    {
        try
        {
            return Ok("OK_RESPONSE_GET_DISH");
        }
        catch (InvalidOperationException ex)
        {
            // Write logs
        }
        catch (Exception ex)
        {
            return StatusCode(500);
        }

        return BadRequest();
    }

     [HttpGet]
     [Route("{id}/rating/check")]
     public async Task<IActionResult>  CAN_USER_RATE_DISH(Guid id)
    {
        try
        {
            return Ok("OK_RESPONSE_GET_DISH");
        }
        catch (InvalidOperationException ex)
        {
            // Write logs
        }
        catch (Exception ex)
        {
            return StatusCode(500);
        }

        return BadRequest();
    }

    [HttpPost]
    [Route("{id}/rating")]
     public async Task<IActionResult>  RATE_DISH_BY_ID(Guid id, int ratingScore)
    {
        try
        {
            return Ok("OK_RESPONSE_GET_DISH");
        }
        catch (InvalidOperationException ex)
        {
            // Write logs
        }
        catch (Exception ex)
        {
            return StatusCode(500);
        }

        return BadRequest();
    }
    



}
