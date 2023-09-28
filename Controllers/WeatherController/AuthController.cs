using BackEndProject.Data;
using BackEndProject.Types;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndProject.Controllers.WeatherController;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{

    private readonly ILogger<AuthController> _logger;
    private readonly APIDBcontext _context;

    public AuthController( ILogger<AuthController> logger, APIDBcontext context)
    {
        _logger = logger;
        _context = context;
    }
    
    [HttpPost(Name = "RegisterUser")]
    public async Task<ActionResult> Register(string name, string email, string password, string phoneNumber , string address)
    {
        try
        {
            var user = new User(name, password, phoneNumber, address, email);
            _context.Add(user);
            await _context.SaveChangesAsync();
            return Ok(user);
        }
        catch (Exception exception)
        {
            return BadRequest(exception.Message);
        }
        
    }

    [HttpGet(Name = "GetUsers")]
    public async Task<ActionResult> Login()
    {
        try
        {
            var user = await _context.Users.ToListAsync();
            return Ok(user);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

}
