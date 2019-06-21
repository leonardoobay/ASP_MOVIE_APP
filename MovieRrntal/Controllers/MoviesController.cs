using MovieRrntal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieRrntal.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek is Love Shrek is Life" };
            return View(movie);
        }
    }
}