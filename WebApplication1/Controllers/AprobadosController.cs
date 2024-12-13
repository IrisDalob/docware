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
    }
}
