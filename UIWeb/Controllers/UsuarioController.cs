using Microsoft.AspNetCore.Mvc;

namespace UIWeb.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
