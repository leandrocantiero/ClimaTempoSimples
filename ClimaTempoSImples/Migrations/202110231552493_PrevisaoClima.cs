namespace ClimaTempoSImples.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PrevisaoClima : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PrevisaoClima",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Clima = c.String(nullable: false),
                    TempMin = c.Decimal(nullable: false),
                    TempMax = c.Decimal(nullable: false),
                })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            DropTable("dbo.PrevisaoClima");
        }
    }
}
