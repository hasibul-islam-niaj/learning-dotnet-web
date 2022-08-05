using System.Diagnostics;
using learning_dotnet_web.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using learning_dotnet_web.Models;
using learning_dotnet_web.Services;

namespace learning_dotnet_web.Controllers;

public class UserController : Controller
{
    private readonly UserService _userService;
    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger, UserService userService)
    {
        _logger = logger;
        _userService = userService;
    }

    public IActionResult All()
    {
        List<User>? users = _userService.GetAll();

        ViewBag.Title = "All Users";
        ViewBag.Users = users;
        
        return View();
    }

    [HttpGet]
    public IActionResult New()
    {
        ViewBag.Title = "New User";
        return View();
    }

    [HttpPost]
    public IActionResult New(User user)
    {
        if (ModelState.IsValid)
        {
            _userService.Save(user);
            ModelState.Clear();
            return RedirectToAction("All", "User");
        }

        ViewBag.Title = "Invalid";
        return View();
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var user = _userService.GetById(id);
        ViewBag.Title = "Update User";
        return View(user);
    }
    
    [HttpPost]
    public IActionResult Edit(User user)
    {
        if (ModelState.IsValid)
        {
            _userService.Update(user);
            ModelState.Clear();
            return RedirectToAction("All", "User");
        }

        ViewBag.Title = "Invalid";
        return View();
    }

    [HttpPost]
    public IActionResult Delete(int id)
    {
        if (ModelState.IsValid)
            _userService.Delete(id);
        
        return RedirectToAction("All", "User");
    }

    public IActionResult Privacy()
    {
        ViewBag.Title = "Privacy Policy";
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}