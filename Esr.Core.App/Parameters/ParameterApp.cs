using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Domain.Parameters;
using Esr.Core.Repository.ConfNumbering;

namespace Esr.Core.App.Parameters
{
    public class ParameterApp
    {
        private readonly IFactoryCommand<Parameter> _epr;
        private object factoryConnection;

        public ParameterApp(IFactoryConnection efc)
        {
            _epr = new ParameterRepo(efc);
        }

        public ParameterApp(object factoryConnection)
        {
            this.factoryConnection = factoryConnection;
        }

        public Parameter FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<Parameter> parameters)
        {
            return _epr.Remove(parameters);
        }

        public bool InsertOrUpdate(Parameter Parameter)
        {
            return _epr.InsertOrUpdate(Parameter);
        }

        public IQueryable<Parameter> Search(Expression<Func<Parameter, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<Parameter> Search()
        {
            return _epr.Search();
        }

        public IQueryable<T> Search<T>(Expression<Func<Parameter, bool>> expression) where T : Parameter
        {
            return _epr.SearchOfType<T>(expression);
        }
    }
}