using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using System.Linq;
using Esr.Module.Parking.Domain;
using Esr.Core.Repository;

namespace Esr.Module.Parking.Repository
{
    public class ParkingAgreementRepo : IFactoryCommand<ParkingAgreement>
    {
        private readonly IFactoryCommand<ParkingAgreement> _efcmd;

        public ParkingAgreementRepo(IFactoryConnection efc)
        {
            IFactoryRepository<ParkingAgreement> efr = new DbContext<ParkingAgreement>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(ParkingAgreement eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(ParkingAgreement eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<ParkingAgreement> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public ParkingAgreement FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<ParkingAgreement> Search(Expression<Func<ParkingAgreement, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<ParkingAgreement> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<ParkingAgreement> AsNoTracking(Expression<Func<ParkingAgreement, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<ParkingAgreement> SqlQuery(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        IQueryable<ParkingAgreement> IFactoryCommand<ParkingAgreement>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        IQueryable<T> IFactoryCommand<ParkingAgreement>.SearchOfType<T>(Expression<Func<ParkingAgreement, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}