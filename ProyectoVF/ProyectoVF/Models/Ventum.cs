using System;
using System.Collections.Generic;

namespace ProyectoVF.Models;

public partial class Ventum
{
    public int IdVenta { get; set; }

    public DateTime? FechaVenta { get; set; }

    public double? MontoVenta { get; set; }

    public int? IdCliente { get; set; }

    public string? EstadoVenta { get; set; }

    public virtual ICollection<DetalleVentum> DetalleVenta { get; set; } = new List<DetalleVentum>();

    public virtual Cliente? IdClienteNavigation { get; set; }
}
