﻿using Microsoft.AspNetCore.Mvc;
using OnlineTickets.Data;
using OnlineTickets.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTickets.Controllers
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

        //Get: Actors/Create
        public IActionResult Create()
        {
            return View();
        }
    }
}
