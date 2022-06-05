using System;
using System.Collections.Generic;

namespace Web.Models
{
    public partial class Factura
    {
        public Factura()
        {
            Lineas = new HashSet<Linea>();
        }

        public int Id { get; set; }
        public double? Descuento { get; set; }
        public double Total { get; set; }
        public string? NombreCliente { get; set; }

        public virtual ICollection<Linea> Lineas { get; set; }
    }
}
