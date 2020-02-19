using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.Address;
using Esr.Core.Domain.RepositoryFactory;
using System.Data.Entity;
using System.Linq;

namespace Esr.Core.Repository.Address
{
    public class PublicPlaceRepo : IFactoryCommand<PublicPlace>
    {
        private readonly IFactoryCommand<PublicPlace> _efcmd;

        public PublicPlaceRepo(IFactoryConnection efc)
        {
            IFactoryRepository<PublicPlace> efr = new DbContext<PublicPlace>();
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(PublicPlace eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(PublicPlace eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<PublicPlace> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public PublicPlace FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<PublicPlace> Search(Expression<Func<PublicPlace, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<PublicPlace> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<PublicPlace> AsNoTracking(Expression<Func<PublicPlace, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<PublicPlace> IFactoryCommand<PublicPlace>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<PublicPlace> IFactoryCommand<PublicPlace>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<PublicPlace>.SearchOfType<T>(Expression<Func<PublicPlace, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
