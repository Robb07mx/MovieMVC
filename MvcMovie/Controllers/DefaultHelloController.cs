using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class DefaultHelloController : Controller
    {
        // GET: DefaultHello
        public ActionResult Index() {
            return View();
        }

        // GET: //DefuaultHello/Welcome
        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello" + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
        
    }
}