namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Oganizacion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ciudads", "CiudadName", c => c.String());
            AddColumn("dbo.Ciudads", "CiudadDescription", c => c.String());
            AddColumn("dbo.Ciudads", "PostalCode", c => c.Int(nullable: false));
            DropColumn("dbo.Ciudads", "Nombre");
            DropColumn("dbo.Ciudads", "Description");
            DropColumn("dbo.Ciudads", "CodigoPostal");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ciudads", "CodigoPostal", c => c.Int(nullable: false));
            AddColumn("dbo.Ciudads", "Description", c => c.String());
            AddColumn("dbo.Ciudads", "Nombre", c => c.String());
            DropColumn("dbo.Ciudads", "PostalCode");
            DropColumn("dbo.Ciudads", "CiudadDescription");
            DropColumn("dbo.Ciudads", "CiudadName");
        }
    }
}
