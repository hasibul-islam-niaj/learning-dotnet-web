using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using learning_dotnet_web.Models;
using learning_dotnet_web.Services.Home;

namespace learning_dotnet_web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AuthorService _authorService;

    public HomeController(ILogger<HomeController> logger, AuthorService authorService)
    {
        _logger = logger;
        _authorService = authorService;
    }

    public IActionResult Index()
    {
        ViewBag.Title = "Home Page";
        return View();
    }

    public IActionResult Privacy()
    {
        ViewBag.Title = "Privacy Policy";
        return View();
    }

    [HttpGet("/application/author")]
    public IActionResult Author()
    {
        // throw new InvalidOperationException("This is for Testing");
        AuthorInfo authorInfo = _authorService.GetAuthorInfo();
        
        ViewBag.Title = "Author Details";
        ViewBag.Author = authorInfo;
        
        return View();
    }

    [HttpPost("/application/author")]
    public IActionResult Author(AuthorMessage authorMessage)
    {
        AuthorInfo authorInfo = new AuthorInfo();
        authorInfo.Name = "Hasibul Islam";
        authorInfo.Position = "Software Engineer";
        authorInfo.Company = "Brain Station - 23 Ltd.";

        ViewBag.Title = "Author Details";
        ViewBag.Author = authorInfo;
        
        if (ModelState.IsValid)
        {
            // Logic for valid
        }
        else
        {
            // Logic for invalid
        }
        
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}