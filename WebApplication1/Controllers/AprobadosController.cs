using Microsoft.AspNetCore.Mvc;

namespace GestorDocumentalDocWare.Controllers
{
    public class AprobadosController : Controller
    {
        public IActionResult DocAprobados()
        {
            ViewBag.HideHeader = true;
            return View();
        }
        public IActionResult CorreoCambioContrasena()
        {
            return View();
        }

        public IActionResult DocRevision()
        {
            return View();
        }

        public IActionResult GenerarDocumento()
        {
            return View();
        }

        public IActionResult Avatares()
        {
            return View();
        }
    }
}
