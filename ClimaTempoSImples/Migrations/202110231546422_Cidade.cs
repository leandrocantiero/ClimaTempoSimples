namespace ClimaTempoSImples.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cidade : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cidades",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Nome = c.String(nullable: false),
                    EstadoId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Estadoes", t => t.EstadoId)
                .Index(t => t.EstadoId);
        }
        
        public override void Down()
        {
            DropTable("dbo.Cidades");
            DropForeignKey("dbo.Cidades", "EstadoId", "dbo.Estadoes");
            DropIndex("dbo.Cidades", new[] { "EstadoId" });
        }
    }
}
