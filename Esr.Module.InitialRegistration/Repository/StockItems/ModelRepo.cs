using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository;
using Esr.Module.InitialRegistration.Domain.StockItems;
using System.Data.Entity;
using System.Linq;

namespace Esr.Module.InitialRegistration.Repository.StockItems
{
    public class ModelRepo : IFactoryCommand<Model>
    {
        private readonly IFactoryCommand<Model> _efcmd;

        public ModelRepo(IFactoryConnection efc)
        {
            IFactoryRepository<Model> efr = new DbContext<Model>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(Model eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(Model eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<Model> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public Model FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<Model> Search(Expression<Func<Model, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<Model> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<Model> AsNoTracking(Expression<Func<Model, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<Model> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IList<Model> IFactoryCommand<Model>.SqlQuery(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        IQueryable<Model> IFactoryCommand<Model>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        IQueryable<T> IFactoryCommand<Model>.SearchOfType<T>(Expression<Func<Model, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
