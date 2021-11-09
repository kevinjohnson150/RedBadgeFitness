using Fitness.Data;
using Fitness.Models.RoutineModels;
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
    public class RoutineController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();

        // GET: Routine
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new RoutineService(userId);
            var model = service.GetRoutines();

            return View(model);
        }

        // GET
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RoutineCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new RoutineService(userId);
            service.CreateRoutine(model);

            if (service.CreateRoutine(model))
            {
                TempData["SaveResult"] = "Your workout was created.";
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }


        // GET: Delete
        //Routine/Delete/{id}
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Routine routine = _db.Routines.Find(id);
            if (routine == null)
            {
                return HttpNotFound();
            }
            return View(routine);
        }

        // POST: Delete
        // Routine/Delete{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            Routine routine = _db.Routines.Find(id);
            _db.Routines.Remove(routine);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Edit
        // Routine/Edit/{id}
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Routine routine = _db.Routines.Find(id);
            if (routine == null)
            {
                return HttpNotFound();
            }
            return View(routine);
        }

        // POST: Edit// Routine/Edit/{id}
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Routine routine)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(routine).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(routine);
        }

        // GET: Details
        // Routine/Details/{id}
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Routine routine = _db.Routines.Find(id);

            if (routine == null)
            {
                return HttpNotFound();
            }
            return View(routine);
        }
    }
}