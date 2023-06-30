using ProyectoVF.Models;
using Microsoft.AspNetCore.Http;
namespace ProyectoVF.Services
{
    public interface ICart
    {
        void add(Carro objProducto);
        IEnumerable<Carro> GetAllCarro();
        IEnumerable<Carro> RemoveObj(int idProducto);
        bool Exists(int idProducto);
        void remove(Carro idProducto);
        void ADD(Ventum objV);
        void ActualizarEstado(int ventaId, string estado);
        void Add(DetalleVentum objDetalle);
    }
}
