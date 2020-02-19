using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository;
using Esr.Module.InitialRegistration.Domain.RH;
using System.Data.Entity;
using System.Linq;

namespace Esr.Module.InitialRegistration.Repository.RH
{
    public class TypePositionFunctionRepo : IFactoryCommand<TypePositionFunction>
    {
        private readonly IFactoryCommand<TypePositionFunction> _efcmd;

        public TypePositionFunctionRepo(IFactoryConnection efc)
        {
            IFactoryRepository<TypePositionFunction> efr = new DbContext<TypePositionFunction>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(TypePositionFunction eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(TypePositionFunction eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<TypePositionFunction> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public TypePositionFunction FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<TypePositionFunction> Search(Expression<Func<TypePositionFunction, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<TypePositionFunction> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<TypePositionFunction> AsNoTracking(Expression<Func<TypePositionFunction, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<TypePositionFunction> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IList<TypePositionFunction> IFactoryCommand<TypePositionFunction>.SqlQuery(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        IQueryable<TypePositionFunction> IFactoryCommand<TypePositionFunction>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        IQueryable<T> IFactoryCommand<TypePositionFunction>.SearchOfType<T>(Expression<Func<TypePositionFunction, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
