using System;
using System.Collections.Generic;

namespace ProyectoVF.Models;

public partial class Product
{
    public int IdProducto { get; set; }

    public string NombreProducto { get; set; } = null!;

    public double PrecioProducto { get; set; }

    public int StockProducto { get; set; }

    public int IdCategoria { get; set; }

    public string? ImgProducto { get; set; }

    public string? DesProducto { get; set; }

    public virtual ICollection<DetalleVentum> DetalleVenta { get; set; } = new List<DetalleVentum>();

    public virtual Categorium IdCategoriaNavigation { get; set; } = null!;
}
