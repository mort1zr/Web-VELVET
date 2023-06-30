using ProyectoVF.Models;

namespace ProyectoVF.Services
{
    public interface IProducto
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int id);
    }
}
