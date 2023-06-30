using ProyectoVF.Models;

namespace ProyectoVF.Services
{
    public interface ICatalogo
    {
        void remove(int id);
        Product IDPRODUCTO(int id);
        void modificarInfo(Product obj);
    }
}
