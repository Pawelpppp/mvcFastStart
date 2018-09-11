using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/Random
        public ActionResult Random()
        {
            var move = new Movie() { Name = "Shrek" };
            return View(move);
        }

        public ActionResult Edit(int id)
        {
            return Content("## Id = " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (pageIndex == null)
                pageIndex = 1;
            if (string.IsNullOrEmpty(sortBy))
            {
                sortBy = "name";
            }
            return Content(string.Format("pageIndex= {0} &sortBy= {1}", pageIndex, sortBy));
        }
    }
}