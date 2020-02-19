using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Stock.Domain.Movements;
using Esr.Module.Stock.Repository.InputsOutPuts;

namespace Esr.Module.Stock.App.InputsOutPuts
{
    public class OutputStockApp
    {
        private readonly IFactoryCommand<OutputStock> _epr;

        public OutputStockApp(IFactoryConnection efc)
        {
            _epr = new OutputStockRepo(efc);
        }

        public OutputStock FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<OutputStock> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(OutputStock OutputStock)
        {
            return _epr.InsertOrUpdate(OutputStock);
        }

        public IQueryable<OutputStock> Search(Expression<Func<OutputStock, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<OutputStock> Search()
        {
            return _epr.Search();
        }

        /// <summary>
        /// Verifica se capa do movimento contém itens.
        /// </summary>
        /// <param name="outputId">ID da capa do movimento de saída.</param>
        /// <returns>Retorna verdadeiro se contém items</returns>
        public bool AnyItems(int outputId)
        {
            return _epr.Search(c => c.Id == outputId).Any(c => c.ItemOutputStocks.Any());
        }

        /// <summary>
        /// Obter código do movimento de saída.
        /// </summary>
        /// <param name="outputId">ID do movimento de saída.</param>
        /// <returns>Retorna o código do movimento de saída.</returns>
        public string GetCode(int outputId)
        {
            return _epr.Search(c => c.Id == outputId).Select(c => c.Code).FirstOrDefault();
        }
    }
}