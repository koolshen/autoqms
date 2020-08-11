using System.Collections.Generic;
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
            { "NSB-qms-nul","NSB" },
            { "Aal-qms-bor","AAL" },
            { "Hob-qms-bro","HOB" },
            { "Bor-qms-ups","BOR" },
            { "MaS-qms-Tas","MAS" },
            { "DAN-qms-stu","DAN" }
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
            var kvalitetManualUrl = "kvalitetsmanual.pdf";

            switch (id)
            {
                case 1:
                    baseUrld = "http://autoqms.gear.host/Content/" + CompaniesDictionary[User.Identity.Name] + "/{0}#page=1";
                    ViewData["file"] = string.Format(baseUrld, kvalitetManualUrl);
                    ViewData["download_link"] = kvalitetManualUrl;
                    break;
                case 2:
                    baseUrld = "http://autoqms.gear.host/Content/" + CompaniesDictionary[User.Identity.Name] + "/{0}#page=2";
                    ViewData["file"] = string.Format(baseUrld, kvalitetManualUrl);
                    break;
                case 3:
                    baseUrld = "http://autoqms.gear.host/Content/" + CompaniesDictionary[User.Identity.Name] + "/{0}#page=6";
                    ViewData["file"] = string.Format(baseUrld, kvalitetManualUrl);
                    ViewData["download_link"] = kvalitetManualUrl;
                    break;
                case 4:
                    baseUrld = "http://autoqms.gear.host/Content/" + CompaniesDictionary[User.Identity.Name] + "/{0}#page=8";
                    ViewData["file"] = string.Format(baseUrld, kvalitetManualUrl);
                    ViewData["download_link"] = kvalitetManualUrl;
                    break;
                case 5:
                    ViewData["file"] = string.Format(baseUrld, "Proces_flow.pdf");
                    ViewData["download_link"] = "Proces_flow.pdf";
                    break;
                case 6:
                    ViewData["file"] = string.Format(baseUrld, "ISO_process.pdf");
                    ViewData["download_link"] = "ISO_process.pdf";
                    break;
                case 7:
                    ViewData["file"] = string.Format(baseUrld, "Risiko-analyse-Bilsyn.pdf");
                    ViewData["download_link"] = "Risiko-analyse-Bilsyn.pdf";
                    break;
                case 8:
                    baseUrld = "http://autoqms.gear.host/Content/" + CompaniesDictionary[User.Identity.Name] + "/{0}#page=4";
                    ViewData["file"] = string.Format(baseUrld, kvalitetManualUrl);
                    ViewData["download_link"] = kvalitetManualUrl;
                    break;
                case 9:
                    ViewData["file"] = string.Format(baseUrld, "Org.Diagram.pdf");
                    ViewData["download_link"] = "Org.Diagram.pdf";
                    break;
                case 10:
                    if (User.Identity.Name == "KAS-qms-num" || User.Identity.Name == "NEM-qms-mer")
                    {
                        ViewData["file"] = string.Format(baseUrld, "Kompetencematrix.xlsx");
                        ViewData["download_link"] = "Kompetencematrix.pdf";
                    }
                    else
                    {
                        ViewData["file"] = string.Format(baseUrld, "Kompetencematrix.pdf");
                        ViewData["download_link"] = "Kompetencematrix.pdf";
                    }
                    break;
                case 11:
                    ViewData["file"] = string.Format(baseUrld, "Auditplan.pdf");
                    ViewData["download_link"] = "Auditplan.pdf";

                    break;
                case 12:
                    ViewData["file"] = string.Format(baseUrld, "_ISO_registreringer.pdf");
                    ViewData["download_link"] = "_ISO_registreringer.pdf";

                    break;
                case 13:
                    baseUrld = "http://autoqms.gear.host/Content/" + CompaniesDictionary[User.Identity.Name] + "/{0}#page=4";
                    ViewData["file"] = string.Format(baseUrld, kvalitetManualUrl);
                    ViewData["download_link"] = kvalitetManualUrl;

                    break;
                case 14:
                    ViewData["file"] = string.Format(baseUrld, "LeverandЫr_vurdering.pdf");
                    ViewData["download_link"] = "LeverandЫr_vurdering.pdf";

                    break;
                case 15:
                    baseUrld = "https://www.fstyr.dk/DA/Krav-til-koretojer/Regler-om-koretojer/Vejledning-om-syn-af-koretojer.aspx";
                    ViewData["file"] = baseUrld;
                    break;
                case 16:
                    ViewData["file"] = string.Format(baseUrld, "ISO_process.pdf");
                    ViewData["download_link"] = "ISO_process.pdf";

                    break;
                case 17:
                    ViewData["file"] = string.Format(baseUrld, "Afvigelsesrapport.pdf");
                    ViewData["download_link"] = "Afvigelsesrapport.pdf";

                    break;
                case 18:
                    ViewData["file"] = string.Format(baseUrld, "Observationsrapport.pdf");
                    ViewData["download_link"] = "Observationsrapport.pdf";

                    break;
                case 19:
                    ViewData["file"] = string.Format(baseUrld, "NЫdsynsrapport.pdf");
                    ViewData["download_link"] = "NЫdsynsrapport.pdf";

                    break;
                case 20:
                    ViewData["file"] = string.Format(baseUrld, "KundetilfredshedsmЖling.pdf");
                    ViewData["download_link"] = "KundetilfredshedsmЖling.pdf";

                    break;
                default:
                    break;
            }

            return View(id);
        }

        [HttpGet]
        public ActionResult GetFile(string filename)
        {
            return File("/Content/" + CompaniesDictionary[User.Identity.Name] + "/" + Request["filename"], "application /pdf", Request["filename"]);
        }
    }
}