using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace autoqms.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.h1 = GetCurrentHeader1();
            ViewBag.h2 = GetCurrentHeader2();

            return View();
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


        private string GetCurrentHeader1()
        {
            var result = "";
            switch (User.Identity.Name.ToLower())
            {
                case "larsen@mail.com":
                    result = "Larsen Bilsyn af 1. januar 2019 IvS";
                    break;
            }

            return result;
        }
        private string GetCurrentHeader2()
        {
            var result = "";
            switch (User.Identity.Name.ToLower())
            {
                case "larsen@mail.com":
                    result = "CVR: 400325576";
                    break;
            }

            return result;
        }
    }

}