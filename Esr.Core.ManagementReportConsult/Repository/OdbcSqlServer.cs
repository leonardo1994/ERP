using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository;

namespace Esr.Module.ControlPainel.Repository
{
    public class OdbcSqlServer<T> : DbContext<T> where T : class
    {


        public override IFactoryConnection FactoryConnection()
        {
            return new DbContext();
        }
    }
}
