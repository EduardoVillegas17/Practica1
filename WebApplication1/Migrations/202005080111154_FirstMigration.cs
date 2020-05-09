namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ciudads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CiudadName = c.String(),
                        CiudadDescription = c.String(),
                        PostalCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Eventoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        Fecha = c.DateTime(nullable: false),
                        CiudadesId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ciudads", t => t.CiudadesId, cascadeDelete: true)
                .Index(t => t.CiudadesId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Eventoes", "CiudadesId", "dbo.Ciudads");
            DropIndex("dbo.Eventoes", new[] { "CiudadesId" });
            DropTable("dbo.Eventoes");
            DropTable("dbo.Ciudads");
        }
    }
}
