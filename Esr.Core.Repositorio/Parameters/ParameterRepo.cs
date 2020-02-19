using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using System.Linq;
using Esr.Core.Domain.Parameters;

namespace Esr.Core.Repository.ConfNumbering
{
    public class ParameterRepo : IFactoryCommand<Parameter>
    {
        private readonly IFactoryCommand<Parameter> _efcmd;

        public ParameterRepo(IFactoryConnection efc)
        {
            IFactoryRepository<Parameter> efr = new DbContext<Parameter>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(Parameter eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(Parameter eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<Parameter> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public Parameter FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<Parameter> Search(Expression<Func<Parameter, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<Parameter> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<Parameter> AsNoTracking(Expression<Func<Parameter, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<Parameter> IFactoryCommand<Parameter>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<Parameter> IFactoryCommand<Parameter>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<Parameter>.SearchOfType<T>(Expression<Func<Parameter, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
