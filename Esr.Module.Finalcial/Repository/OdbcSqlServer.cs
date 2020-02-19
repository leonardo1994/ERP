using Esr.Core.Domain.ClassBase;
using Esr.Core.Repository;

namespace Esr.Module.Financial.Repository
{
    public class OdbcSqlServer<T> : DbContext<T> where T : class, IEntityBase
    {
    }
}
