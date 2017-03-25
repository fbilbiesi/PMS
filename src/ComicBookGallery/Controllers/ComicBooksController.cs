using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookGallery.Models;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {

        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final Issue</p>",
                Artists = new Artist[]
             {
                new Artist() {Name ="Dan Slott", Role="Script"},
                new Artist() {Name ="Humberto Ramos", Role="Pencils"},
                new Artist() {Name ="Victor Olazaba", Role="Inks"},
                new Artist() {Name ="Edgar Delgado", Role="Colors"},
                new Artist() {Name ="Chris Eliopoulos", Role="Letters"},
   
             }

             };
            
            return View(comicBook);
        } 

            

            

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
