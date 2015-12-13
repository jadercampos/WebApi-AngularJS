using System.Data.Entity.ModelConfiguration;
using WebApiAngularJS.Domain.Entities;

namespace WebApiAngularJS.Repositories.EF.Config
{
    public class EstabelecimentoMap : EntityTypeConfiguration<Estabelecimento>
    {
        public EstabelecimentoMap()
        {
            Property(e => e.Nome).IsRequired().HasMaxLength(100);
            Property(e => e.Descricao).HasMaxLength(300);
        }
    }
}
