using Microsoft.EntityFrameworkCore;
using ProyectoVF.Models;

namespace ProyectoVF.Services
{
    public class LoginRepository : ILogin
    {
        public VentaC connec = new VentaC();
        public void add(Cliente obj)
        {
            connec.Clientes.Add(obj);
            connec.SaveChanges();
        }

        public Cliente GetCliente(string dirrecion)
        {
            var obj = (from cli in connec.Clientes where cli.DireccionCliente == dirrecion select cli).SingleOrDefault();
            return obj;
        }
        
        public IEnumerable<Cliente> GetClientes()
        {
            return connec.Clientes;
        }
        
        public IEnumerable<Ventum> GetVentas()
        {
            return connec.Venta;
        }

        public IEnumerable<Ventum> GetVentasPorFecha(DateTime fechainicio, DateTime fechafin)
        {
            var ventas = connec.Venta.Where(f => f.FechaVenta >= fechainicio && f.FechaVenta <= fechafin).ToList();
            return ventas;
        }
        
        public IEnumerable<Ventum> GetCompra(int idCliente)
        {
            return connec.Venta.Where(v => v.IdCliente == idCliente).ToList();
        }

        public bool ValidarUsu(Cliente obj)
        {
            var x = (from usu in connec.Clientes where usu.DireccionCliente == obj.DireccionCliente && usu.PasswordCliente == obj.PasswordCliente select usu).FirstOrDefault();
            if (x == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
