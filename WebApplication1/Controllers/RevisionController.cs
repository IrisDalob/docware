using Microsoft.AspNetCore.Mvc;

namespace GestorDocumentalDocWare.Controllers
{
    public class RevisionController : Controller
    {
        public IActionResult DocRevision()
        {
            ViewBag.HideHeader = true;
            return View();
        }
    }
}
