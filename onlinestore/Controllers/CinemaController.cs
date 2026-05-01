using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using onlinestore.Data;

namespace onlinestore.Controllers
{
    public class CinemaController : Controller
    {
        private readonly AppDbContext _context;


        public CinemaController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var cinemas = await _context.Cinemas.ToListAsync();
            return View();
        }
    }
}
