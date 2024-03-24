using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductoId { get; set; }

        [Required]
        [MaxLength(100)] // Establece la longitud máxima del nombre del producto
        public string Nombre { get; set; }

        [Required]
        [MaxLength(250)] // Establece la longitud máxima del nombre del producto
        public string Descripcion { get; set; }

        [Required]
        public decimal PrecioUnitario { get; set; }

        [Required]
        public int Stock { get; set; }

        [Required]
        public bool Estado { get; set; }

        // Propiedad de navegación para la relación uno a muchos con DetalleVenta
        public List<DetalleVenta> Detalles { get; set; }

        // Constructor por defecto
        public Producto() { }

        // Constructor para inicializar propiedades
        public Producto(string nombre, string descripción, decimal precioUnitario, int stock, bool estado)
        {
            Nombre = nombre;
            Descripcion = descripción;
            PrecioUnitario = precioUnitario;
            Stock = stock;
            Estado = estado;
        }
    }
}
