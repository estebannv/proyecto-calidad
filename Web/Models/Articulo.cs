using System;
using System.Collections.Generic;

namespace Web.Models
{
    public partial class Articulo
    {
        public Articulo()
        {
            Lineas = new HashSet<Linea>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public double Costo { get; set; }
        public double? Impuesto { get; set; }

        public virtual ICollection<Linea> Lineas { get; set; }
    }
}
