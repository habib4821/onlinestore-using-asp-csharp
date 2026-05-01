 using Microsoft.AspNetCore.Mvc;
using onlinestore.Data;

namespace onlinestore.Controllers
{
    public class ActorController : Controller
    {
        private readonly AppDbContext _context;


        public ActorController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Actors.ToList();
            return View();
        }
    }
}
