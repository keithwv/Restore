using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class BaseApiController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}