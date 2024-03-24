using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Venta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VentaId { get; set; }

        [Required]
        public DateTime FechaVenta { get; set; }

        [Required]
        public decimal TotalVenta { get; set; }

        // Propiedad de navegación para la relación uno a muchos con DetalleVenta
        public List<DetalleVenta> Detalles { get; set; }

        // Constructor por defecto
        public Venta() 
        {
            Detalles = new List<DetalleVenta>();
        }

        // Constructor para inicializar propiedades
        public Venta(decimal totalVenta)
        {
            TotalVenta = totalVenta;
        }
    }
}
