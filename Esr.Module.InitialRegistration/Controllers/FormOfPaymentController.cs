using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.App.RH;
using Esr.Module.InitialRegistration.App.Sales;
using Esr.Module.InitialRegistration.Domain.RH;
using Esr.Module.InitialRegistration.Domain.Sales;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Esr.Module.InitialRegistration.Controllers
{
    public class FormOfPaymentController
    {
        private FormOfPaymentApp _FormOfPaymentApp; 
        private IFactoryConnection _connection;

        public FormOfPaymentController(IFactoryConnection connection)
        {
            _connection = connection;
            _FormOfPaymentApp = new FormOfPaymentApp(connection);
        }
        
        public bool Save(FormOfPayment FormOfPayment)
        {
            _FormOfPaymentApp.InsertOrUpdate(FormOfPayment);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _FormOfPaymentApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _FormOfPaymentApp.Remove(_FormOfPaymentApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// FormOfPayments List.
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.Description }</returns>
        public IList ListFormOfPayment()
        {
            return _FormOfPaymentApp.Search()
                .Select(c => new
                { c.Id, c.Code, c.Description, c.TypePaymant }).ToList();
        }

        public bool Remove(Expression<Func<FormOfPayment, bool>> expression)
        {
            _FormOfPaymentApp.Remove(_FormOfPaymentApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<FormOfPayment, bool>> expression)
        {
            return _FormOfPaymentApp.Search(expression).ToList();
        }

        public FormOfPayment FindId(int id)
        {
            return _FormOfPaymentApp.FindId(id);
        }
    }
}