﻿using Fitness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedBadgeFitness.WebMVC.Controllers
{
    [Authorize]
    public class WorkoutController : Controller
    {
        // GET: Workout
        public ActionResult Index()
        {
            var model = new WorkoutListItem[0];
            return View(model);
        }

        // GET
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(WorkoutCreate model)
        {
            if (ModelState.IsValid)
            {

            }
            return View(model);
        }
    }
}