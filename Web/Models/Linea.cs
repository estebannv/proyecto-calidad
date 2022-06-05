using System;
using System.Collections.Generic;

namespace Web.Models
{
    public partial class Linea
    {
        public int IdFactura { get; set; }
        public int IdArticulo { get; set; }
        public int Cantidad { get; set; }

        public virtual Articulo IdArticuloNavigation { get; set; } = null!;
        public virtual Factura IdFacturaNavigation { get; set; } = null!;
    }
}
