using System;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Funerary.Domain.OrderOfServices;
using Esr.Module.Funerary.Repository.OrderOfServices;
using System.Collections.Generic;

namespace Esr.Module.Funerary.App.OrderOfServices
{
    public class OsDocumentApp
    {
        private readonly IFactoryCommand<OsDocument> _epr;

        public OsDocumentApp(IFactoryConnection efc)
        {
            _epr = new OsDocumentRepo(efc);
        }

        public OsDocument FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<OsDocument> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(OsDocument OsDocument)
        {
            return _epr.InsertOrUpdate(OsDocument);
        }

        public IQueryable<OsDocument> Search(Expression<Func<OsDocument, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<OsDocument> Search()
        {
            return _epr.Search();
        }
    }
}