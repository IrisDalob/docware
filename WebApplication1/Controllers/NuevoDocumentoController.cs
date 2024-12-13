using Microsoft.AspNetCore.Mvc;

namespace GestorDocumentalDocWare.Controllers
{
    public class NuevoDocumentoController : Controller
    {
        public IActionResult GenerarDocumento()
        {
            ViewBag.HideHeader = true;
            return View();
        }
    }
}
