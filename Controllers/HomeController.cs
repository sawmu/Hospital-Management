using Microsoft.AspNetCore.Mvc;

namespace Hms.Web.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View();
}
