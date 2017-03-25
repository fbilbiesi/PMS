using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {

        public ActionResult Detail()
        {
           ViewBag.SeriesTitle = "The amazing Spider-Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final Issue</p>";
            ViewBag.Artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"
            };

            return View();

            //if (DateTime.Today.DayOfWeek == DayOfWeek.Wednesday)
            //{
            //    return new RedirectResult("http://www.google.com");
            //}
            //return Content("Today is not the day");
            //return new ContentResult()
            //{

            //    Content = "hello from comic books controller"
            //};
            //return "";
        }

    }
}