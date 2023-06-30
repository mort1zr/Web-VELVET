using System;
using System.Collections.Generic;

namespace ProyectoVF.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string? NombreCliente { get; set; }

    public string? ApellidoCliente { get; set; }

    public string? DireccionCliente { get; set; }

    public string? PasswordCliente { get; set; }

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
}
