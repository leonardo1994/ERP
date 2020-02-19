using System.Collections.Generic;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using System.Collections;
using Esr.Module.Funerary.App.OrderOfServices;
using Esr.Module.Funerary.Domain.OrderOfServices;
using System;
using System.Linq.Expressions;

namespace Esr.Module.Funerary.Controllers
{
    public class OsDocumentController
    {
        private OsDocumentApp _OsDocumentApp;
        private OrderOfServiceApp _orderOfServiceApp;
        private IFactoryConnection _connection;

        public OsDocumentController(IFactoryConnection connection)
        {
            _connection = connection;
            _OsDocumentApp = new OsDocumentApp(connection);
            _orderOfServiceApp = new OrderOfServiceApp(connection);
        }

        public bool Save(OsDocument OsDocument)
        {
            _OsDocumentApp.InsertOrUpdate(OsDocument);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _OsDocumentApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _OsDocumentApp.Remove(_OsDocumentApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        public string GetNumberOs(int orderOfServiceId)
        {
            return _orderOfServiceApp.FindId(orderOfServiceId).NumberOs;
        }

        /// <summary>
        /// OsDocument List.
        /// </summary>
        /// <returns>{ c.Id, c.Archive, c.Description, c.OrderOfService.NumberOs }</returns>
        public IList ListOsDocument()
        {
            return _OsDocumentApp.Search()
                .Select(c => new
                { c.Id, c.Archive, c.Description, c.OrderOfService.NumberOs }).ToList();
        }

        /// <summary>
        /// OsDocument List.
        /// </summary>
        /// <returns>{ c.Id, c.Archive, c.Description, c.OrderOfService.NumberOs }</returns>
        public IList ListOsDocument(Expression<Func<OsDocument, bool>> expression)
        {
            return _OsDocumentApp.Search(expression)
                .Select(c => new
                { c.Id, c.Integration, c.Archive, c.Description, c.OrderOfService.NumberOs }).ToList();
        }

        public IList Search(Expression<Func<OsDocument, bool>> expression)
        {
            return _OsDocumentApp.Search(expression).ToList();
        }

        public bool Remove(Expression<Func<OsDocument, bool>> expression)
        {
            _OsDocumentApp.Remove(_OsDocumentApp.Search(expression).ToList());
            return _connection.Save();
        }

        public OsDocument FindId(int id)
        {
            return _OsDocumentApp.FindId(id);
        }
    }
}