﻿using Microsoft.AspNetCore.Mvc;

namespace MentorTemplate.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
