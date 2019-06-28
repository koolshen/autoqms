using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace autoqms.Controllers
{
    public class KvalitetsSystemController : Controller
    {
        // GET: KvalitetsSystem
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult HTML(int id)
        {
            return View();
        }


        public ActionResult Document(int id)
        {
            return View();
        }
    }
}