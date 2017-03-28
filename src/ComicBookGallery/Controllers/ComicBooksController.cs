using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookGallery.Data;
using ComicBookGallery.Models;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {

        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Index()
        {
            var comicBook = _comicBookRepository.GetComicBooks();
            return View(comicBook);
        }

        public ActionResult Detail(int? Id)
        {
            if (Id == null)
            {
                return HttpNotFound();
            }

            ComicBook comicBook = _comicBookRepository.GetComicBook(Id.Value);
            
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
