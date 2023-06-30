using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProyectoVF.Models;
using ProyectoVF.Services;

namespace ProyectoVF.Controllers
{
    public class CartController : Controller
    {
        private readonly ICart _cart;
        public CartController(ICart cart)
        {
            _cart = cart;
        }
        public IActionResult Index(string idProducto, string imgProducto, string nomProducto, string desProducto, string preProducto)
        {
            Carro objCarro = new Carro();
            
            objCarro.ID = int.Parse(idProducto);
            // objCarro.Img = Encoding.UTF8.GetBytes(imgProducto);  //ACA SE SUPONE QUE PARSEAS A BYTE
            objCarro.Name = nomProducto;
            objCarro.Description = desProducto;
            objCarro.Precio = double.Parse(preProducto);

            if (!_cart.Exists(objCarro.ID))
            {
                _cart.add(objCarro);
            }
            else
            {
                TempData["Message"] = "El producto ya está en el carrito.";
            }
            double total = _cart.GetAllCarro().Sum(c => c.Precio);
            ViewBag.Total = total;
            
            return RedirectToAction("Index", "Main");
            }
        public IActionResult CartDetails()
        {
            IEnumerable<Carro> carros = _cart.GetAllCarro();
            double total = carros.Sum(c => c.Precio);
            ViewBag.Total = total;
            
            return View(carros);
        }
        public IActionResult Remove(int id)
        {
            var lst = _cart.RemoveObj(id);
            return View(lst);
        }
        public IActionResult Metodopago()
        {
            if (HttpContext.Session.GetString("sUsuario") != null)
            {
                IEnumerable<Carro> carros = _cart.GetAllCarro();
                decimal montoTotal = (decimal)carros.Sum(c => c.Precio);
                ViewBag.MontoTotal = montoTotal;
                var objSesion = JsonConvert.DeserializeObject<Cliente>(HttpContext.Session.GetString("sUsuario"));
                int idCliente = objSesion.IdCliente;
                var ventum = new Ventum
                {
                    IdCliente = objSesion.IdCliente,
                    FechaVenta = DateTime.Parse(DateTime.Now.Date.ToString("d-M-y")),
                    EstadoVenta = "Pendiente",
                };
                ventum.MontoVenta = (double)montoTotal;
                _cart.ADD(ventum);
                TempData["IdVenta"] = ventum.IdVenta;
                return View("Metodopago",ventum);
            }
            
            return RedirectToAction("Login", "Login");
        }

        public IActionResult Detalles()
        {
            return RedirectToAction("Listo", "Cart");
        }

        public IActionResult Listo()
        {
            int idVenta = (int)TempData["IdVenta"];
            _cart.ActualizarEstado(idVenta, "Realizada");
            return RedirectToAction("Piolas", "Cart");
        }
        public IActionResult Piolas()
        {
            return View();
        }
    }
}
