using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.RepositoryFactory;
using System.Linq;

namespace Esr.Core.Repository
{
    // Autor: LEONARDO TEIXEIRA DOS SANTOS SILVA
    // CNPJ: 23.416.009/0001-83
    // 2015 ©LEONARDO TEIXEIRA DOS SANTOS SILVA 43342439831 | Todos os Direitos  Reservados
    public class DbContext<TEObject> : IFactoryRepository<TEObject> where TEObject : class, IEntityBase
    {
        public virtual IFactoryCommand<TEObject> FactoryCommand(IFactoryConnection conexao)
        {
            return new DbContextCommand<TEObject>(conexao);
        }
    }
}
