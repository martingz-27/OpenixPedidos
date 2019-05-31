namespace Modelo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prueba1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Personas", "Pedido_id", c => c.Int());
            CreateIndex("dbo.Personas", "Pedido_id");
            AddForeignKey("dbo.Personas", "Pedido_id", "dbo.Pedidoes", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Personas", "Pedido_id", "dbo.Pedidoes");
            DropIndex("dbo.Personas", new[] { "Pedido_id" });
            DropColumn("dbo.Personas", "Pedido_id");
        }
    }
}
