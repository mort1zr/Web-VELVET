using ProyectoVF.Models;
using Microsoft.AspNetCore.Http;
using System.Transactions;

namespace ProyectoVF.Services
{
    public class CartRepository : ICart
    {
        public VentaC connec = new VentaC();
        private List<Carro> lst = new List<Carro>();
        public void add(Carro objProducto)
        {
            lst.Add(objProducto);
        }
        public void ActualizarEstado(int ventaId, string estado)
        {
            var venta = connec.Venta.FirstOrDefault(v => v.IdVenta == ventaId);
            if (venta != null)
            {
                venta.EstadoVenta = estado;
                connec.SaveChanges();
            }
        }

        public void ADD(Ventum objV)
        {
            connec.Venta.Add(objV);
            connec.SaveChanges();
        }

        public bool Exists(int idProducto)
        {
            return lst.Any(item => item.ID == idProducto);
        }

        public IEnumerable<Carro> GetAllCarro()
        {
            return lst;
        }

        public void remove(Carro idProducto)
        {
            lst.Remove(idProducto);
        }

        public IEnumerable<Carro> RemoveObj(int idProducto)
        {
            lst.RemoveAll(x => x.ID == idProducto);
            return lst;
        }

        public void Add(DetalleVentum objDetalle)
        {
            connec.DetalleVenta.Add(objDetalle);
            connec.SaveChanges();
        }
    }
}
