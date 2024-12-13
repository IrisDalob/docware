using Microsoft.AspNetCore.Mvc;

namespace GestorDocumentalDocWare.Controllers
{
    public class AvataresController : Controller
    {
        public IActionResult SeleccionAvatares()
        {
            ViewBag.HideHeader = true;
            return View();
        }
    }
}
