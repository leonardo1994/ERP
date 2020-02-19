﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository;
using System.Linq;
using Esr.Module.InitialRegistration.Domain.Sales;

namespace Esr.Module.InitialRegistration.Repository.Sales
{
    public class FormOfPaymentRepo : IFactoryCommand<FormOfPayment>
    {
        private readonly IFactoryCommand<FormOfPayment> _efcmd;

        public FormOfPaymentRepo(IFactoryConnection efc)
        {
            IFactoryRepository<FormOfPayment> efr = new DbContext<FormOfPayment>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(FormOfPayment eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(FormOfPayment eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<FormOfPayment> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public FormOfPayment FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<FormOfPayment> Search(Expression<Func<FormOfPayment, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<FormOfPayment> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<FormOfPayment> AsNoTracking(Expression<Func<FormOfPayment, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }


        IList<FormOfPayment> IFactoryCommand<FormOfPayment>.SqlQuery(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        IQueryable<FormOfPayment> IFactoryCommand<FormOfPayment>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        IQueryable<T> IFactoryCommand<FormOfPayment>.SearchOfType<T>(Expression<Func<FormOfPayment, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}