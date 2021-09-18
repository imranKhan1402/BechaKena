using BK.Data;
using BK.Data.Services;
using BK.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BK.Controllers
{
    public class ActorsController : Controller
    {
        //private readonly AppDbContext _context;

        //public ActorsController(AppDbContext context)
        //{
        //    _context = context;
        //}
        private readonly IActorService _service;

        public ActorsController(IActorService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            _service.Add(actor);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var actordetails = _service.GetById(id);
            if (actordetails == null) return View("Empty");
            return View(actordetails);
        }
    }
}
