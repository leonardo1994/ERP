using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.FleetManagement.Domain.Drives;
using Esr.Module.FleetManagement.Repository.Drives;

namespace Esr.Module.FleetManagement.App.Drives
{
    public class DriveApp
    {
        private readonly IFactoryCommand<Drive> _epr;

        public DriveApp(IFactoryConnection efc)
        {
            _epr = new DriveRepo(efc);
        }

        public Drive FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<Drive> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(Drive Drive)
        {
            return _epr.InsertOrUpdate(Drive);
        }

        public IQueryable<Drive> Search(Expression<Func<Drive, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<Drive> Search()
        {
            return _epr.Search();
        }
    }
}