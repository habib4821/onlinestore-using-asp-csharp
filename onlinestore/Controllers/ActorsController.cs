 using Microsoft.AspNetCore.Mvc;
using onlinestore.Data;

namespace onlinestore.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;


        public ActorsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Actors.ToList();
            Console.WriteLine(data);
            return View(data);
        }
    }
}
