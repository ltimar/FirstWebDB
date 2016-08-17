using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationWebDB.Models;

namespace WebApplicationWebDB.Controllers
{
    public class LoriVideosController : Controller
    {
        private ApplicationDbContext _loriDBContext;

        public LoriVideosController()
        {
            _loriDBContext = new ApplicationDbContext();
        }
        // GET: LoriVideos
        public ActionResult Inkdex()
        {
            var videos = _loriDBContext.LoriDBSetVideos.ToList(); // ToList = LINQ command
            return View("Index",videos );
        }
        public ActionResult Index()
        {
            var videos = _loriDBContext.LoriDBSetVideos.ToList(); // ToList = LINQ command
            return View(videos);
        }
    }
}