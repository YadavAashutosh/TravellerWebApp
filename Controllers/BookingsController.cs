using Microsoft.AspNetCore.Mvc;

namespace TravellerWebApp.Controllers
{
    public class BookingsController : Controller
    {
        public IActionResult Index()
        {
            var bookings = new List<object>
            {
                new { Destination = "Goa", Price = 12000, Image = "/images/goa.jpg" },
                new { Destination = "Manali", Price = 15000, Image = "/images/manali.jpg" },
                new { Destination = "Kerala", Price = 18000, Image = "/images/kerala.jpg" }
            };

            return View(bookings);
        }

        public IActionResult Details(string destination)
        {
            var details = new
            {
                Destination = destination,
                Description = $"{destination} is a beautiful travel spot with amazing views and attractions.",
                Image = $"/images/{destination.ToLower()}.jpg",
                Price = 15000
            };

            return View(details);
        }
    }
}
