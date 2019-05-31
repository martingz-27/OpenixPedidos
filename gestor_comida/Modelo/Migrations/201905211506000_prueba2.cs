namespace Modelo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prueba2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Guarnicions", "_NombreGuarnicion", c => c.String(nullable: false));
            DropColumn("dbo.Guarnicions", "_Nombre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Guarnicions", "_Nombre", c => c.String(nullable: false));
            DropColumn("dbo.Guarnicions", "_NombreGuarnicion");
        }
    }
}
