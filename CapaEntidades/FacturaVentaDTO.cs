using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class FacturaVentaDTO
    {
        public int Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public string Producto { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
    }
}
