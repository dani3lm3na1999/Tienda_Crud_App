using CapaEntidades;
using System;
using System.Data.Entity;
using System.Linq;

namespace CapaDatos
{
    public class ContextoBD : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'ContextoBD' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'CapaDatos.ContextoBD' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'ContextoBD'  en el archivo de configuración de la aplicación.
        public ContextoBD()
            : base("data source=.\\SQLEXPRESS;initial catalog=Tienda_CRUD_DB;integrated security=True;encrypt=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework")
        {
        }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Venta> Ventas { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<DetalleVenta> Detalle { get; set; }
    }
}