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
    public class NaturePositionFunctionRepo : IFactoryCommand<NaturePositionFunction>
    {
        private readonly IFactoryCommand<NaturePositionFunction> _efcmd;

        public NaturePositionFunctionRepo(IFactoryConnection efc)
        {
            IFactoryRepository<NaturePositionFunction> efr = new DbContext<NaturePositionFunction>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(NaturePositionFunction eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(NaturePositionFunction eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<NaturePositionFunction> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public NaturePositionFunction FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<NaturePositionFunction> Search(Expression<Func<NaturePositionFunction, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<NaturePositionFunction> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<NaturePositionFunction> AsNoTracking(Expression<Func<NaturePositionFunction, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<NaturePositionFunction> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<NaturePositionFunction> IFactoryCommand<NaturePositionFunction>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        IQueryable<T> IFactoryCommand<NaturePositionFunction>.SearchOfType<T>(Expression<Func<NaturePositionFunction, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
