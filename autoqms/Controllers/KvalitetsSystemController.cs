using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace autoqms.Controllers
{
    public class KvalitetsSystemController : Controller
    {

        public static Dictionary<string, string> CompaniesDictionary { get; set; } = new Dictionary<string, string>
        {
            { "LAR-qms-stu","LAR" },
            { "TOP-qms-bbe","TOP" },
            { "AGB-qms-kob","AGB" },
            { "ARN-qms-ing","ARN" },
            { "STE-qms-vej","STE" },
            { "KAS-qms-num","KAS" },
            { "NEM-qms-mer","NEM" },

        };


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

        public ActionResult Dokument(int id)
        {
            string baseUrlShared = "https://docs.google.com/gview?url=http://autoqms.gear.host/Content/Shared/{0}&embedded=true";
            string baseUrld = "https://docs.google.com/gview?url=http://autoqms.gear.host/Content/" + CompaniesDictionary[User.Identity.Name] + "/{0}&embedded=true";

            switch (id)
            {
                case 1:
                    baseUrld = "http://autoqms.gear.host/Content/" + CompaniesDictionary[User.Identity.Name] + "/{0}#page=1";
                    ViewData["file"] = string.Format(baseUrld, "kvalitetsmanual.pdf");
                    break;
                case 2:
                    ViewData["file"] = string.Format(baseUrld, "kvalitetsmanual.pdf");
                    break;
                case 3:
                    ViewData["file"] = string.Format(baseUrld, "kvalitetsmanual.pdf");
                    break;
                case 4:
                    ViewData["file"] = string.Format(baseUrld, "kvalitetsmanual.pdf");
                    break;
                case 5:
                    ViewData["file"] = string.Format(baseUrld, "Proces_flow.pdf");
                    break;
                case 6:
                    ViewData["file"] = string.Format(baseUrld, "ISO_process.pdf");
                    break;
                case 7:
                    ViewData["file"] = string.Format(baseUrld, "Risiko-analyse-Bilsyn.pdf");
                    break;
                case 8:
                    baseUrld = "http://autoqms.gear.host/Content/" + CompaniesDictionary[User.Identity.Name] + "/{0}#page=4";
                    ViewData["file"] = string.Format(baseUrld, "kvalitetsmanual.pdf");
                    break;
                case 9:
                    ViewData["file"] = string.Format(baseUrld, "Org.Diagram.pdf");
                    break;
                case 10:
                    ViewData["file"] = string.Format(baseUrld, "Kompetencematrix.pdf");
                    break;
                case 11:
                    ViewData["file"] = string.Format(baseUrld, "Auditplan.pdf");
                    break;
                case 12:
                    ViewData["file"] = string.Format(baseUrld, "_ISO_registreringer.pdf");
                    break;
                case 13:
                    baseUrld = "http://autoqms.gear.host/Content/" + CompaniesDictionary[User.Identity.Name] + "/{0}#page=4";
                    ViewData["file"] = string.Format(baseUrld, "kvalitetsmanual.pdf");
                    break;
                case 14:
                    ViewData["file"] = string.Format(baseUrld, "LeverandЫr_vurdering.pdf");
                    break;
                case 15:
                    baseUrld = "https://www.fstyr.dk/DA/Krav-til-koretojer/Regler-om-koretojer/Vejledning-om-syn-af-koretojer.aspx";
                    ViewData["file"] = baseUrld;
                    break;
                case 16:
                    ViewData["file"] = string.Format(baseUrld, "ISO_process.pdf");
                    break;
                case 17:
                    ViewData["file"] = string.Format(baseUrld, "Afvigelsesrapport.pdf");
                    break;
                case 18:
                    ViewData["file"] = string.Format(baseUrld, "Observationsrapport.pdf");
                    break;
                case 19:
                    ViewData["file"] = string.Format(baseUrld, "NЫdsynsrapport.pdf");
                    break;
                case 20:
                    ViewData["file"] = string.Format(baseUrld, "KundetilfredshedsmЖling.pdf");
                    break;
                default:
                    break;
            }

            return View(id);
        }
    }
}