namespace ClimaTempoSImples.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ClimaTempoSImples.Data.ClimaTempoSImplesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ClimaTempoSImples.Data.ClimaTempoSImplesContext";
        }

        protected override void Seed(ClimaTempoSImples.Data.ClimaTempoSImplesContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            
            context.Estadoes.AddOrUpdate(
              p => p.Nome,
              new Models.Estado { Nome = "São Paulo", Uf = "SP" },
              new Models.Estado { Nome = "Paraná", Uf = "PR" },
              new Models.Estado { Nome = "Rio Grande do Norte", Uf = "RN" },
              new Models.Estado { Nome = "Mato Grosso do Sul", Uf = "MS" }
            );
            
        }
    }
}
