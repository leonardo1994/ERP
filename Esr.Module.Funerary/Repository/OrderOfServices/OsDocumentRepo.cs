using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Funerary.Domain.OrderOfServices;
using System.Data.Entity;
using System.Linq;
using Esr.Core.Repository;

namespace Esr.Module.Funerary.Repository.OrderOfServices
{
    public class OsDocumentRepo : IFactoryCommand<OsDocument>
    {
        private readonly IFactoryCommand<OsDocument> _efcmd;

        public OsDocumentRepo(IFactoryConnection efc)
        {
            IFactoryRepository<OsDocument> efr = new DbContext<OsDocument>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(OsDocument eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(OsDocument eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<OsDocument> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public OsDocument FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<OsDocument> Search(Expression<Func<OsDocument, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<OsDocument> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<OsDocument> AsNoTracking(Expression<Func<OsDocument, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<OsDocument> IFactoryCommand<OsDocument>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<OsDocument> IFactoryCommand<OsDocument>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<OsDocument>.SearchOfType<T>(Expression<Func<OsDocument, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
