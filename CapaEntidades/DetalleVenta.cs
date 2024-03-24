using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class DetalleVenta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DetalleVentaId { get; set; }

        [Required]
        public int VentaId { get; set; } // ID de la venta a la que pertenece este detalle

        [Required]
        public int ProductoId { get; set; }

        [Required]
        public int Cantidad { get; set; }

        // Propiedad de navegación para la relación con Producto
        [ForeignKey("ProductoId")]
        public Producto Producto { get; set; }

        // Propiedad de navegación para la relación con Venta
        [ForeignKey("VentaId")]
        public Venta Venta { get; set; }

        // Constructor por defecto
        public DetalleVenta() { }

        // Constructor para inicializar propiedades
        public DetalleVenta(int ventaId, int productoId, int cantidad)
        {
            VentaId = ventaId;
            ProductoId = productoId;
            Cantidad = cantidad;
        }
    }
}
