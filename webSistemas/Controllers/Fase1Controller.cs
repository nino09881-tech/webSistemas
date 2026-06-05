using Microsoft.AspNetCore.Mvc;

namespace Compiladores.Controllers
{
    public class Fase1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
