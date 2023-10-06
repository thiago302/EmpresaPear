using Microsoft.AspNetCore.Mvc;

namespace EmpresaPear.Controllers
{
    public class EmpresaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
