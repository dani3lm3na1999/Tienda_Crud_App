namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Chg_Detall_Venta : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DetalleVentas",
                c => new
                    {
                        DetalleVentaId = c.Int(nullable: false, identity: true),
                        VentaId = c.Int(nullable: false),
                        ProductoId = c.Int(nullable: false),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Cantidad = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DetalleVentaId)
                .ForeignKey("dbo.Productoes", t => t.ProductoId, cascadeDelete: true)
                .ForeignKey("dbo.Ventas", t => t.VentaId, cascadeDelete: true)
                .Index(t => t.VentaId)
                .Index(t => t.ProductoId);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        ProductoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Descripcion = c.String(nullable: false, maxLength: 250),
                        PrecioUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Stock = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProductoId);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        VentaId = c.Int(nullable: false, identity: true),
                        FechaVenta = c.DateTime(nullable: false),
                        TotalVenta = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.VentaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DetalleVentas", "VentaId", "dbo.Ventas");
            DropForeignKey("dbo.DetalleVentas", "ProductoId", "dbo.Productoes");
            DropIndex("dbo.DetalleVentas", new[] { "ProductoId" });
            DropIndex("dbo.DetalleVentas", new[] { "VentaId" });
            DropTable("dbo.Ventas");
            DropTable("dbo.Productoes");
            DropTable("dbo.DetalleVentas");
        }
    }
}
