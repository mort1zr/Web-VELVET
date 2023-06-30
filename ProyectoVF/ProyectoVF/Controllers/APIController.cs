using Microsoft.AspNetCore.Mvc;

namespace ProyectoVF.Controllers
{
    public class APIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
