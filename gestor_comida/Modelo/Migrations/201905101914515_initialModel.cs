namespace Modelo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        _Nombre = c.String(nullable: false),
                        _Apellido = c.String(nullable: false),
                        _Telefono = c.String(nullable: false),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Guarnicions",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        _Nombre = c.String(nullable: false),
                        _Cantidad = c.Int(nullable: false),
                        Pedido_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Pedidoes", t => t.Pedido_id)
                .Index(t => t.Pedido_id);
            
            CreateTable(
                "dbo.Pedidoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        _Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Platoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        _Nombre = c.String(nullable: false),
                        _Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Pedido_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Pedidoes", t => t.Pedido_id)
                .Index(t => t.Pedido_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Platoes", "Pedido_id", "dbo.Pedidoes");
            DropForeignKey("dbo.Guarnicions", "Pedido_id", "dbo.Pedidoes");
            DropIndex("dbo.Platoes", new[] { "Pedido_id" });
            DropIndex("dbo.Guarnicions", new[] { "Pedido_id" });
            DropTable("dbo.Platoes");
            DropTable("dbo.Pedidoes");
            DropTable("dbo.Guarnicions");
            DropTable("dbo.Personas");
        }
    }
}
