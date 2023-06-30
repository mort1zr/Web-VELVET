using ProyectoVF.Models;

namespace ProyectoVF.Services
{
    public interface ILogin
    {
        bool ValidarUsu(Cliente usuario);
        void add(Cliente obj);
        IEnumerable<Cliente> GetClientes();
        Cliente GetCliente(string dirrecion);

        IEnumerable<Ventum> GetCompra(int idCliente);
        IEnumerable<Ventum> GetVentasPorFecha(DateTime fechainicio, DateTime fechafin);
        IEnumerable<Ventum> GetVentas();
    }
}
