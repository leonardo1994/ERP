using System;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using System.Collections.Generic;
using Esr.Module.Stock.Domain.Integration;
using Esr.Module.Stock.Repository.Integration;
using Esr.Module.Stock.App.InputsOutputs;
using Esr.Module.Stock.App.InputsOutPuts;
using Esr.Module.Stock.MapperConfig;
using Esr.Module.Stock.Domain.Movements;

namespace Esr.Module.Stock.App.Integration
{
    public class IntegrationCapeStockApp
    {
        private readonly IFactoryCommand<IntegrationCapeStock> _epr;
        private readonly InputStockApp _inputStockApp;
        private readonly OutputStockApp _outputStockApp;
        private readonly StockMapper _stockMapper;
        private readonly IFactoryConnection _conn;

        public IntegrationCapeStockApp(IFactoryConnection efc)
        {
            _epr = new IntegrationCapeStockRepo(efc);
            _inputStockApp = new InputStockApp(efc);
            _outputStockApp = new OutputStockApp(efc);
            _stockMapper = new StockMapper();
            _conn = efc;
        }

        public IntegrationCapeStock FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<IntegrationCapeStock> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(IntegrationCapeStock integrationCapeStock)
        {
            var integration = _epr.Search(integrationCapeStock.GetExpressionByRelation()).FirstOrDefault();

            if (integration != null)
                integration = _stockMapper.StartMapper(integrationCapeStock, integration);

            if (integration != null)
            {
                _epr.InsertOrUpdate(integration);

                if (_conn.Save())
                {
                    InputStock inputStock = null;
                    OutputStock outputStock = null;

                    switch (integration.TypeIntegration)
                    {
                        case TypeIntegration.InputStock:

                            inputStock = _inputStockApp.Search(c => c.IntegrationCapeStockId == integration.Id).FirstOrDefault();
                            _inputStockApp.InsertOrUpdate(_stockMapper.StartMapper(integration, inputStock ?? new InputStock()));
                            break;

                        case TypeIntegration.OutputStock:

                            outputStock = _outputStockApp.Search(c => c.IntegrationCapeStockId == integration.Id).FirstOrDefault();
                            _outputStockApp.InsertOrUpdate(_stockMapper.StartMapper(integration, outputStock ?? new OutputStock()));
                            break;

                        default:
                            return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                _epr.InsertOrUpdate(integrationCapeStock);

                if (_conn.Save())
                {
                    switch (integrationCapeStock.TypeIntegration)
                    {
                        case TypeIntegration.InputStock:

                            _inputStockApp.InsertOrUpdate(_stockMapper.StartMapper<InputStock>(integrationCapeStock));
                            break;

                        case TypeIntegration.OutputStock:

                            _outputStockApp.InsertOrUpdate(_stockMapper.StartMapper<OutputStock>(integrationCapeStock));
                            break;

                        default:
                            return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            return _conn.Save();
        }

        /// <summary>
        /// Pesquisar Ukey do movimento de estoque integrado.
        /// </summary>
        /// <param name="propertyName">Nome da propriedade de relação.</param>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public int GetIdStock(Expression<Func<IntegrationCapeStock, bool>> expression, TypeIntegration typeIntegration)
        {
            if (typeIntegration == TypeIntegration.InputStock)
            {
                var integrationId = _epr.Search(expression).FirstOrDefault().Id;
                return _inputStockApp.Search(c => c.IntegrationCapeStockId == integrationId).FirstOrDefault().Id;
            }
            else
            {
                var integrationId = _epr.Search(expression).FirstOrDefault()?.Id;
                return _outputStockApp.Search(c => c.IntegrationCapeStockId == integrationId).FirstOrDefault().Id;
            }
        }

        public IQueryable<IntegrationCapeStock> Search(Expression<Func<IntegrationCapeStock, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<IntegrationCapeStock> Search()
        {
            return _epr.Search();
        }
    }
}