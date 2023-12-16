using BackEndProject.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndProject.Controllers.WeatherController;

[ApiController]
[Route("api/account")]
public class AuthController : ControllerBase
{

    private readonly ILogger<AuthController> _logger;
    private readonly APIDBContext _context;

    public AuthController( ILogger<AuthController> logger, APIDBContext context)
    {
        _logger = logger;
        _context = context;
    }
    

}
