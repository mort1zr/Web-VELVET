using Microsoft.AspNetCore.Mvc;
using ProyectoVF.Services;

namespace ProyectoVF.Controllers
{
    public class MainController : Controller
    {
        private readonly IProducto _producto;
        public MainController(IProducto producto)
        {
            _producto = producto;
        }
        public IActionResult Index()
        {
            return View(_producto.GetProducts());
        }
        [Route("Main/Detalle/{codigo}")]
        public IActionResult Detalle(int codigo)
        {
            ViewData["cod"] = codigo;
            return View(_producto.GetProductById(codigo));
        }
    }
}
