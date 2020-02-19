﻿using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository;

namespace Esr.Module.Stock.Repository
{
    public class OdbcSqlServer<T> : DbContext<T> where T : class, IEntityBase
    {
    }
}
