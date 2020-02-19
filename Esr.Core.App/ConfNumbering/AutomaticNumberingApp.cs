using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Domain.ConfNumbering;
using Esr.Core.Repository.ConfNumbering;

namespace Esr.Core.App.ConfNumbering
{
    public class AutomaticNumberingApp
    {
        private readonly IFactoryCommand<AutomaticNumbering> _epr;
        private object factoryConnection;

        public AutomaticNumberingApp(IFactoryConnection efc)
        {
            _epr = new AutomaticNumberingRepo(efc);
        }

        public AutomaticNumberingApp(object factoryConnection)
        {
            this.factoryConnection = factoryConnection;
        }

        public AutomaticNumbering FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<AutomaticNumbering> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(AutomaticNumbering AutomaticNumbering)
        {
            return _epr.InsertOrUpdate(AutomaticNumbering);
        }

        public IQueryable<AutomaticNumbering> Search(Expression<Func<AutomaticNumbering, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<AutomaticNumbering> Search()
        {
            return _epr.Search();
        }

        /// <summary>
        /// Gerar sequência de numereção 
        /// </summary>
        /// <param name="tableId">Chave da tabela</param>
        /// <param name="field">Nome do campo</param>
        /// <returns>Sequência gerada</returns>
        public int? GerarSequencia(int tableId, string field)
        {
            IList<AutomaticNumbering> autNumering = new List<AutomaticNumbering>();

            var sql = "Update AutomaticNumbering Set NextNumber = NextNumber + 1 " +
                      "Where DbTableId = @p0 and FieldName = @p1 " +
                      "Select * From AutomaticNumbering " +
                      "Where DbTableId = @p0 and FieldName = @p1 ";
            autNumering = _epr.SqlQuery(sql, tableId, field);

            return autNumering.Any() ? autNumering?.First()?.NextNumber : null;
        }
    }
}