using System.Collections.Generic;
using System.Linq;
using WebApiAngularJS.Domain.Entities;
using WebApiAngularJS.Domain.Interfaces;

namespace WebApiAngularJS.Repositories.EF
{
    public class EstabelecimentoRepository : RepositoryBase<Estabelecimento>, IEstabelecimentoRepository
    {
        public IEnumerable<Estabelecimento> GetByName(string name)
        {
            return Context.Estabelecimentos.Where(e => e.Nome.Contains(name)).ToList();
        }
    }
}
