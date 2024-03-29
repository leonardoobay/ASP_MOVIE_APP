﻿using MovieRrntal.Models;
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
        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }
        //movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
       

            return Content(String.Format("pageIndex" +pageIndex + "& sortBy " + sortBy, pageIndex, sortBy));

        }
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
         public ActionResult ByReleaseDate (int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}