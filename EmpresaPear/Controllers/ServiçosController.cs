using Microsoft.AspNetCore.Mvc;

namespace EmpresaPear.Controllers
{
    public class ServiçosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
