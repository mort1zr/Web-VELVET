using ProyectoVF.Models;

namespace ProyectoVF.Services
{
    public class ProductoRepository : IProducto
    {
        private VentaC conexion = new VentaC(); 
        public Product GetProductById(int id)
        {
            var obj = (from pro in conexion.Products where pro.IdProducto == id select pro).Single();
            return obj;
        }

        public IEnumerable<Product> GetProducts()
        {
            return conexion.Products;
        }
    }
}
