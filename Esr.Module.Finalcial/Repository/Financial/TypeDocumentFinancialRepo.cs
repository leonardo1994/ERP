using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using System.Linq;
using Esr.Module.Financial.Domain.Financial;

namespace Esr.Module.Financial.Repository.Financial
{
    public class TypeDocumentFinancialRepo : IFactoryCommand<TypeDocumentFinancial>
    {
        private readonly IFactoryCommand<TypeDocumentFinancial> _efcmd;

        public TypeDocumentFinancialRepo(IFactoryConnection efc)
        {
            IFactoryRepository<TypeDocumentFinancial> efr = new OdbcSqlServer<TypeDocumentFinancial>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(TypeDocumentFinancial eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(TypeDocumentFinancial eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<TypeDocumentFinancial> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public TypeDocumentFinancial FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<TypeDocumentFinancial> Search(Expression<Func<TypeDocumentFinancial, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<TypeDocumentFinancial> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<TypeDocumentFinancial> AsNoTracking(Expression<Func<TypeDocumentFinancial, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<TypeDocumentFinancial> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<TypeDocumentFinancial> IFactoryCommand<TypeDocumentFinancial>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<TypeDocumentFinancial>.SearchOfType<T>(Expression<Func<TypeDocumentFinancial, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}