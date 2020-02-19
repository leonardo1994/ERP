using System;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using System.Collections.Generic;
using Esr.Module.InitialRegistration.Domain.Sales;
using Esr.Module.InitialRegistration.Repository.Sales;

namespace Esr.Module.InitialRegistration.App.Sales
{
    public class FormOfPaymentApp
    {
        private readonly IFactoryCommand<FormOfPayment> _epr;

        public FormOfPaymentApp(IFactoryConnection efc)
        {
            _epr = new FormOfPaymentRepo(efc);
        }

        public FormOfPayment FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<FormOfPayment> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(FormOfPayment FormOfPayment)
        {
            return _epr.InsertOrUpdate(FormOfPayment);
        }

        public IQueryable<FormOfPayment> Search(Expression<Func<FormOfPayment, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<FormOfPayment> Search()
        {
            return _epr.Search();
        }
    }
}