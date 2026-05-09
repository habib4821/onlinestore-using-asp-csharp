using Microsoft.AspNetCore.Mvc;
using onlinestore.Data;
using onlinestore.Data.Services;

namespace onlinestore.Controllers
{
    public class ActorsController : Controller
    {

        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }
    }
}
