using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProyectoVF.Models;

namespace ProyectoVF.Controllers
{
    public class ProyectoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //No borrar
        public IActionResult Informe()
        {
            return View();
        }
     
        //No borrar
        public IActionResult Contacto()
        {
            return View();
        }
    }
}
