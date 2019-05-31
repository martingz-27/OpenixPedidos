namespace Modelo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Personas", "_Rol", c => c.String(nullable: false));
            DropColumn("dbo.Personas", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Personas", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Personas", "_Rol");
        }
    }
}
