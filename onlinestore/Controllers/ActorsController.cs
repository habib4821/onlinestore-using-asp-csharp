using Microsoft.AspNetCore.Mvc;
using onlinestore.Data;
using onlinestore.Data.Services;
using onlinestore.Models;
using System.Diagnostics;
using System.Net.NetworkInformation;

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
            var data = await _service.GetAllAsync();
            return View(data);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")] Actor actor)
        {
            if (ModelState.IsValid)
            {
                return View(actor);
            }
            _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));

        }
        public async Task<IActionResult> Details(int id)
        {
            Debug.WriteLine($"ID = {id}");
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("Empty");
            return View(actorDetails);
        }
    }
}
