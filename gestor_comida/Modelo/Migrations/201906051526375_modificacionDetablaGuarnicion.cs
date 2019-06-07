namespace Modelo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modificacionDetablaGuarnicion : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Guarnicions", "_Cantidad");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Guarnicions", "_Cantidad", c => c.Int(nullable: false));
        }
    }
}
