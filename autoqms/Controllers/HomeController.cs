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
            ViewBag.h3 = GetCurrentHeader3();

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
                case "lar-qms-stu":
                    result = "Larsen Bilsyn af 1. januar 2019 IvS";
                    break;
                case "top-qms-bbe":
                    result = "Top Bilsyn ApS";
                    break;
                case "agb-qms-kob":
                    result = "AG DRIVE-IN BILSYN ApS";
                    break;
                case "arn-qms-ing":
                    result = "Arno Bilsyn ApS";
                    break;
                case "ste-qms-vej":
                    result = "Bilsyn Stevns /Andreas Agerskov";
                    break;
                case "kas-qms-num":
                    result = "Kastrup Bilsyn";
                    break;
                case "nem-qms-mer":
                    result = "BILSYN Marslev ApS";
                    break;
                case "nsb-qms-nul":
                    result = "Nordsjællands Bilsyn ApS";
                    break;
            }

            return result;
        }

        private string GetCurrentHeader2()
        {
            var result = "";
            switch (User.Identity.Name.ToLower())
            {
                case "lar-qms-stu":
                    result = "CVR: 400325576";
                    break;
                case "top-qms-bbe":
                    result = "CVR: 37691038";
                    break;
                case "agb-qms-kob":
                    result = "35520376";
                    break;
                case "arn-qms-ing":
                    result = "37768820";
                    break;
                case "ste-qms-vej":
                    result = "40002855";
                    break;
                case "kas-qms-num":
                    result = "25725336";
                    break;
                case "nem-qms-mer":
                    result = "35533745";
                    break;
                case "nsb-qms-nul":
                    result = "33499426";
                    break;
            }

            return result;
        }
        private string GetCurrentHeader3()
        {
            var result = "";
            switch (User.Identity.Name.ToLower())
            {
                case "":
                    result = "";
                    break;
                default:
                    result = "Kvalitetsstyring";
                    break;
            }

            return result;
        }

    }

}