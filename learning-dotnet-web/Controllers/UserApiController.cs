using learning_dotnet_web.Data.Entities;
using learning_dotnet_web.Services;
using Microsoft.AspNetCore.Mvc;

namespace learning_dotnet_web.Controllers;

// [Route("api/[Controller]")]
[Route("api/users")]
public class UserApiController : Controller
{
    private readonly UserService _userService;
    private readonly ILogger<UserApiController> _logger;

    public UserApiController(UserService userService, ILogger<UserApiController> logger)
    {
        _userService = userService;
        _logger = logger;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        List<User> users = _userService.GetAll();
        _logger.LogInformation("Get All.....");
        return Ok(users);
    }

    [HttpPost("new")]
    public IActionResult New([FromBody] User user)
    {
        if (ModelState.IsValid)
        {
            _userService.Save(user);
            return Created("/api/users", user);
            // return Ok(user);
        }

        return BadRequest(ModelState);
    }
}