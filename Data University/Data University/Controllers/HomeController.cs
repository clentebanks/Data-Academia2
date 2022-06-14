using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Data_University.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Curso_Python()
        {
            return View();
        }

        public ActionResult Curso_R()
        {
            return View();
        }

        public ActionResult Curso_Mapas_Leaftlet()
        {
            return View();
        }

        public ActionResult Curso_SIG()
        {
            return View();
        }

        public ActionResult Curso_SIG_Intermedio()
        {
            return View();
        }

        public ActionResult Cursos()
        {
            return View();
        }

        public ActionResult SIG_Sensores_Remotos()
        {
            return View();
        }

        public ActionResult SAplicaciones_Web_Mapping()
        {
            return View();
        }

        public ActionResult Análisis_Visualización_Datos()
        {
            return View();
        }

        public ActionResult Test_Playlist()
        {
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
    }
}