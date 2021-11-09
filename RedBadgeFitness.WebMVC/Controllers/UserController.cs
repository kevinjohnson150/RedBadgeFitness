using Fitness.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedBadgeFitness.WebMVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        private ApplicationDbContext _db = new ApplicationDbContext();
        public ActionResult Index()
        {
            List<User> userList = _db.Users.ToList();
            List<User> orderedList = userList.ToList();
            return View(orderedList);
        }

        // Get: User
        public ActionResult Create()
        {
            return View();
        }

        // POST: User
        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                _db.Users.Add(user);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}