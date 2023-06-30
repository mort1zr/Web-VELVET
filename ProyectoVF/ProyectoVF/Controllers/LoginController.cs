using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProyectoVF.Models;
using ProyectoVF.Services;

namespace ProyectoVF.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogin _login;
        private readonly IProducto _producto;
        public LoginController(ILogin login, IProducto producto)
        {
            _login = login;
            _producto = producto;
        }
        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("sUsuario") != null)
            {
                var objSesion = JsonConvert.DeserializeObject<Cliente>(HttpContext.Session.GetString("sUsuario"));
                return RedirectToAction("DatosCliente", objSesion);
            }
            return View();
        }
        public IActionResult Registro()
        {
            return View();
        }
        public IActionResult Comprobar(Cliente login)
        {
            if (_login.ValidarUsu(login))
            {
                var cliente = _login.GetCliente(login.DireccionCliente);
                var setting = new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                };
                HttpContext.Session.SetString("sUsuario", JsonConvert.SerializeObject(cliente,setting));
                HttpContext.Session.SetString("sDireccionCliente", cliente.DireccionCliente); 
                
                if(cliente.DireccionCliente == "admin@gmail.com")
                {
                    return RedirectToAction("VistaAdmin");
                }
                else
                {
                    return RedirectToAction("DatosCliente", cliente);
                }
            }
            else
            {
                return View("Login");
            }
        }

        public IActionResult VistaAdmin(string filtro)
        {
            var prod = _producto.GetProducts();
            switch (filtro)
            {
                case "Id":
                    prod = prod.OrderBy(p => p.IdProducto).ToList();
                    break;
                case "precio":
                    prod = prod.OrderBy(p => p.PrecioProducto).ToList();
                    break;
                case "Categoria":
                    prod = prod.OrderBy(p => p.IdCategoria).ToList();
                    break;
                case "Nombre":
                    prod = prod.OrderBy(p => p.NombreProducto).ToList();
                    break;
                default:
                    break;
            }
            return View(prod);
        }
        
        public IActionResult Consulta()
        {
            return View(_login.GetVentas());
        }
        public IActionResult Filtrar(DateTime fechainicio, DateTime fechafin)
        {
            var facturasFiltradas = _login.GetVentasPorFecha(fechainicio, fechafin);
            return View("VentasFiltradas", facturasFiltradas);
        }

        public IActionResult DatosCliente()
        {
            var clienteJson = HttpContext.Session.GetString("sUsuario");
            var cliente = JsonConvert.DeserializeObject<Cliente>(clienteJson);
            ViewData["direccion"] = cliente.DireccionCliente;

            var compras = _login.GetCompra(cliente.IdCliente);
            ViewData["compras"]=compras;
            return View(cliente);
        }
        public IActionResult Crear(Cliente obj)
        {
            _login.add(obj);
            return Redirect("Login");
        }

        public IActionResult CerrarSesion()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
