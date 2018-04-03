using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBLL;
using Model;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public IIndexBLL  IndexBLL { get; set; }
        public ActionResult Index()
        {
            var job = IndexBLL.GetEntity(x => x.ID == 2);
            return View(job);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}