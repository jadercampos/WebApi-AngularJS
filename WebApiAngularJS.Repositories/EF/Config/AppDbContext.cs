using System.Data.Entity;
using WebApiAngularJS.Domain.Entities;
using WebApiAngularJS.Repositories.EF.Config;

namespace WebApiAngularJS.Repositories.EF
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(): base("WebApiAngularJS") 
        { 
        
        }

        public DbSet<Estabelecimento> Estabelecimentos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EstabelecimentoMap());
        }
    }
}
