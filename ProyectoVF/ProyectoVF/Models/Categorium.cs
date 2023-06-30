using System;
using System.Collections.Generic;

namespace ProyectoVF.Models;

public partial class Categorium
{
    public int IdCategoria { get; set; }

    public string? NombreCategoria { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
