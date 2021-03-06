using Fitness.Data;
using Fitness.Models;
using Fitness.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace RedBadgeFitness.WebMVC.Controllers
{
    [Authorize]
    public class WorkoutController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        // GET: Workout
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new WorkoutService(userId);
            var model = service.GetWorkouts();

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
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new WorkoutService(userId);
            service.CreateWorkout(model);

            if (service.CreateWorkout(model))
            {
                TempData["SaveResult"] = "Your workout was created.";
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }


        // GET: Delete
        //Workout/Delete/{id}
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Workout workout = _db.Workouts.Find(id);
            if (workout == null)
            {
                return HttpNotFound();
            }
            return View(workout);
        }

        // POST: Delete
        // Wokrout/Delete{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            Workout workout = _db.Workouts.Find(id);
            _db.Workouts.Remove(workout);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Edit
        // Workout/Edit/{id}
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Workout workout = _db.Workouts.Find(id);
            if (workout == null)
            {
                return HttpNotFound();
            }
            return View(workout);
        }

        // POST: Edit// Workout/Edit/{id}
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Workout workout)
        {
            if (!ModelState.IsValid)
            {
                _db.Entry(workout).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(workout);
        }

        // GET: Details
        // Workout/Details/{id}
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Workout workout = _db.Workouts.Find(id);

            if (workout == null)
            {
                return HttpNotFound();
            }
            return View(workout);
        }
    }
}