using System.Collections.Generic;
using WebApiAngularJS.Domain.Entities;

namespace WebApiAngularJS.Domain.Interfaces
{
    public interface IEstabelecimentoRepository : IRepositoryBase<Estabelecimento>
    {
        IEnumerable<Estabelecimento> GetByName(string name);
    }
}
