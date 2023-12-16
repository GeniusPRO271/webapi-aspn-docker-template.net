using BackEndProject.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndProject.Controllers.WeatherController;

[ApiController]
[Route("api/account")]
public class AuthController : ControllerBase
{

    private readonly ILogger<AuthController> _logger;
    private readonly APIDBcontext _context;

    public AuthController( ILogger<AuthController> logger, APIDBcontext context)
    {
        _logger = logger;
        _context = context;
    }
    

}
