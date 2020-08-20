using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Formulario.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Pagina em construção.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "O NOSSO CONTATO.";

            return View();
        }
    }
}