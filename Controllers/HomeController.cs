using Microsoft.AspNetCore.Mvc;

namespace TravellerWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Privacy() => View();
    }
}
