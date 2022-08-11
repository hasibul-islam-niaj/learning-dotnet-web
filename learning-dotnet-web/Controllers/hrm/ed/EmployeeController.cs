using Microsoft.AspNetCore.Mvc;

namespace learning_dotnet_web.Controllers.hrm.ed;

public class EmployeeController : Controller
{
    public IActionResult New()
    {
        return View();
    }
}