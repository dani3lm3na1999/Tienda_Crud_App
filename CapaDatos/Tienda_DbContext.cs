using CapaEntidades;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CapaDatos
{
    public partial class Tienda_DbContext : DbContext
    {
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<DetalleVenta> Detalle { get; set; }

        public Tienda_DbContext()
            : base("name=Tienda_DbContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
