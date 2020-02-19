using System.Collections.Generic;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using System.Collections;
using System.Linq.Expressions;
using System;
using Esr.Module.Financial.App.Receive;
using Esr.Module.Financial.Domain.Receive;
using Esr.Module.Financial.App.Financial;
using Esr.Module.Financial.Domain.Financial;

namespace Esr.Module.Financial.Controllers.Financial
{
    public class TypeDocumentFinancialController
    {
        private TypeDocumentFinancialApp _TypeDocumentFinancialApp;
        private IFactoryConnection _connection;

        public TypeDocumentFinancialController(IFactoryConnection connection)
        {
            _connection = connection;
            _TypeDocumentFinancialApp = new TypeDocumentFinancialApp(connection);
        }

        public bool Save(TypeDocumentFinancial TypeDocumentFinancial)
        {
            _TypeDocumentFinancialApp.InsertOrUpdate(TypeDocumentFinancial);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _TypeDocumentFinancialApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _TypeDocumentFinancialApp.Remove(_TypeDocumentFinancialApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// TypeDocumentFinancials List
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.TypeDocumentFinancialName, c.Cnh }</returns>
        public IList ListTypeDocumentFinancial()
        {
            return _TypeDocumentFinancialApp.Search()
                .Select(c => new
                { c.Id, c.TypeDocumentCode, TypeDocumentDescription = c.TypeDocumentCode + " - " + c.TypeDocumentDescription }).ToList();
        }

        public bool Remove(Expression<Func<TypeDocumentFinancial, bool>> expression)
        {
            _TypeDocumentFinancialApp.Remove(_TypeDocumentFinancialApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<TypeDocumentFinancial, bool>> expression)
        {
            return _TypeDocumentFinancialApp.Search(expression).ToList();
        }

        public TypeDocumentFinancial FindId(int id)
        {
            return _TypeDocumentFinancialApp.FindId(id);
        }
    }
}