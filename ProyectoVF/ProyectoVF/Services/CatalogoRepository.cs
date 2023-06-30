using ProyectoVF.Models;

namespace ProyectoVF.Services
{
    public class CatalogoRepository : ICatalogo
    {
        private VentaC connec = new VentaC();
        public Product IDPRODUCTO(int id)
        {
            var ObjFound = (from pro in connec.Products where pro.IdProducto == id select pro).Single();
            return ObjFound;
        }

        public void modificarInfo(Product obj)
        {
            var proEdit = (from pro in connec.Products where pro.IdProducto == obj.IdProducto select pro).FirstOrDefault();
            proEdit.NombreProducto = obj.NombreProducto;
            proEdit.PrecioProducto = obj.PrecioProducto;
            proEdit.DesProducto = obj.DesProducto;
            proEdit.StockProducto = obj.StockProducto;
            proEdit.IdCategoria = obj.IdCategoria;
            connec.SaveChanges();
        }

        public void remove(int id)
        {
            var obj = (from pro in connec.Products where pro.IdProducto == id select pro).Single();
            connec.Products.Remove(obj);
            connec.SaveChanges();
        }
    }
}
