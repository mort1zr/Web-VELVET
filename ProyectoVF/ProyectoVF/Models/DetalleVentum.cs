using System;
using System.Collections.Generic;

namespace ProyectoVF.Models;

public partial class DetalleVentum
{
    public int IdVenta { get; set; }

    public int IdProducto { get; set; }

    public double PrecioVenta { get; set; }

    public int Cantidad { get; set; }

    public int IdDv { get; set; }

    public virtual Product IdProductoNavigation { get; set; } = null!;

    public virtual Ventum IdVentaNavigation { get; set; } = null!;
}
