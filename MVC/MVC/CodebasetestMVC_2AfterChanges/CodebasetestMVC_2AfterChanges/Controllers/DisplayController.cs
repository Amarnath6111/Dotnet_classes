using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodebasetestMVC_2AfterChanges.Models;

namespace CodebasetestMVC_2AfterChanges.Controllers
{
    public class DisplayController : Controller
    {
        static MovieDbContext db = new MovieDbContext();
        // GET: Display
        public ActionResult Index()
        {
            var List1 = db.Movies.ToList();
            Console.WriteLine("enter the year to find movies released in (2000 or 2011)");
            //int year = Convert.ToInt32(Console.ReadLine());
            int year = 2000;
            ViewBag.MovieList= List1.FindAll(x => x.DateofRelease > DateTime.Parse($"{year}-01-01") & x.DateofRelease < DateTime.Parse($"{year}-12-30"));
      
            return View();
        }
    }
}