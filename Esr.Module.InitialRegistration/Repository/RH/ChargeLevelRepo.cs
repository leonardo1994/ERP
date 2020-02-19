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
    public class ChargeLevelRepo : IFactoryCommand<ChargeLevel>
    {
        private readonly IFactoryCommand<ChargeLevel> _efcmd;

        public ChargeLevelRepo(IFactoryConnection efc)
        {
            IFactoryRepository<ChargeLevel> efr = new DbContext<ChargeLevel>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(ChargeLevel eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(ChargeLevel eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<ChargeLevel> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public ChargeLevel FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<ChargeLevel> Search(Expression<Func<ChargeLevel, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<ChargeLevel> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<ChargeLevel> AsNoTracking(Expression<Func<ChargeLevel, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<ChargeLevel> IFactoryCommand<ChargeLevel>.SqlQuery(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        IQueryable<ChargeLevel> IFactoryCommand<ChargeLevel>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        IQueryable<T> IFactoryCommand<ChargeLevel>.SearchOfType<T>(Expression<Func<ChargeLevel, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
