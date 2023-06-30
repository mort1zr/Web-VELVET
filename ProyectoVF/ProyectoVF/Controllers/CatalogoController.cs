using Microsoft.AspNetCore.Mvc;
using ProyectoVF.Models;
using ProyectoVF.Services;

namespace ProyectoVF.Controllers
{
    public class CatalogoController : Controller
    {
        private readonly ICatalogo _catalogo;
        private readonly IProducto _producto;
        public CatalogoController(ICatalogo catalogo, IProducto producto)
        {
            _catalogo = catalogo;
            _producto = producto;
        }
        public IActionResult Catalogo(string filtro)
        {
            var productos = _producto.GetProducts();
            switch (filtro)
            {
                case "Id":
                    productos = productos.OrderBy(p => p.IdProducto).ToList();
                    break;
                case "precio":
                    productos = productos.OrderBy(p => p.PrecioProducto).ToList();
                    break;
                case "Categoria":
                    productos = productos.OrderBy(p => p.IdCategoria).ToList();
                    break;
                case "Nombre":
                    productos = productos.OrderBy(p => p.NombreProducto).ToList();
                    break;
                default:
                    break;
            }
            return View(productos);
        }

        [Route("Catalogo/Modificar/{id}")]
        public IActionResult Modificar(int id)
        {
            return View(_catalogo.IDPRODUCTO(id));
        }

        public IActionResult changeDetails(Product obj)
        {
            _catalogo.modificarInfo(obj);
            return RedirectToAction("VistaAdmin","Login");
        }

        [Route("Catalogo/Eliminar/{id}")]
        public IActionResult Eliminar(int id)
        {
            _catalogo.remove(id);
            return RedirectToAction("VistaAdmin", "Login");
        }
    }
}
