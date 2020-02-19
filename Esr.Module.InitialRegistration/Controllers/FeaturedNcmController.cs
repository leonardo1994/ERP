using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.App.StockItems;
using Esr.Module.InitialRegistration.Domain.StockItems;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Esr.Module.InitialRegistration.Controllers
{
    public class FeaturedNcmController
    {
        private FeaturedNcmApp _FeaturedNcmApp; 
        private IFactoryConnection _connection;

        public FeaturedNcmController(IFactoryConnection connection)
        {
            _connection = connection;
            _FeaturedNcmApp = new FeaturedNcmApp(connection);
        }
        
        public bool Save(FeaturedNcm FeaturedNcm)
        {
            _FeaturedNcmApp.InsertOrUpdate(FeaturedNcm);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _FeaturedNcmApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _FeaturedNcmApp.Remove(_FeaturedNcmApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// FeaturedNcms List.
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.Description }</returns>
        public IList ListFeaturedNcm()
        {
            return _FeaturedNcmApp.Search()
                .Select(c => new
                { c.Id, c.Code, c.Description }).ToList();
        }

        /// <summary>
        /// FeaturedNcms List.
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.Description }</returns>
        public IList Search(Expression<Func<FeaturedNcm, bool>> expression)
        {
            return _FeaturedNcmApp.Search(expression)
                .Select(c => new
                { c.Id, c.Code, c.Description }).ToList();
        }

        public bool Remove(Expression<Func<FeaturedNcm, bool>> expression)
        {
            _FeaturedNcmApp.Remove(_FeaturedNcmApp.Search(expression).ToList());
            return _connection.Save();
        }

        public FeaturedNcm FindId(int id)
        {
            return _FeaturedNcmApp.FindId(id);
        }
    }
}