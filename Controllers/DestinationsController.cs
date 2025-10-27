using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravellerWebApp.Data;

namespace TravellerWebApp.Controllers
{
    public class DestinationsController : Controller
    {
        private readonly TravellerDbContext _db;
        public DestinationsController(TravellerDbContext db) => _db = db;

        public async Task<IActionResult> Index() => View(await _db.Destinations.ToListAsync());
        public async Task<IActionResult> Details(int id)
        {
            var dest = await _db.Destinations.FindAsync(id);
            if (dest == null) return NotFound();
            return View(dest);
        }
    }
}
