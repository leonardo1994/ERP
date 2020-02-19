using System;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using System.Collections.Generic;
using Esr.Module.Stock.Domain.Integration;
using Esr.Module.Stock.Repository.Integration;
using Esr.Module.Stock.Domain.Movements;
using Esr.Module.Stock.App.InputsOutputs;
using Esr.Module.Stock.App.InputsOutPuts;
using Esr.Module.Stock.MapperConfig;

namespace Esr.Module.Stock.App.Integration
{
    public class IntegrationItemsStockApp
    {
        private readonly IFactoryCommand<IntegrationItemsStock> _epr;
        private readonly ItemInputStockApp _itemInputStockApp;
        private readonly ItemOutputStockApp _itemOutputStockApp;
        private readonly StockMapper _stockMapper;
        private readonly IFactoryConnection _conn;

        public IntegrationItemsStockApp(IFactoryConnection efc)
        {
            _epr = new IntegrationItemsStockRepo(efc);
            _itemInputStockApp = new ItemInputStockApp(efc);
            _itemOutputStockApp = new ItemOutputStockApp(efc);
            _stockMapper = new StockMapper();
            _conn = efc;
        }

        public IntegrationItemsStock FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<IntegrationItemsStock> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(IntegrationItemsStock integrationItemsStock)
        {
            var integration = _epr.Search(integrationItemsStock.GetExpressionByRelation()).FirstOrDefault();

            if (integration != null)
                integration = _stockMapper.StartMapper(integrationItemsStock, integration);

            if (integration != null)
            {
                _epr.InsertOrUpdate(integration);

                _conn.Save();

                ItemInputStock itemInputStock = null;
                ItemOutputStock itemOutputStock = null;

                switch (integration.TypeIntegration)
                {
                    case TypeIntegration.InputStock:

                        itemInputStock = _itemInputStockApp.Search(c => c.IntegrationItemsStockId == integration.Id).FirstOrDefault();
                        _itemInputStockApp.InsertOrUpdate(_stockMapper.StartMapper(integration, itemInputStock));

                        break;
                    case TypeIntegration.OutputStock:

                        itemOutputStock = _itemOutputStockApp.Search(c => c.IntegrationItemsStockId == integration.Id).FirstOrDefault();
                        _itemOutputStockApp.InsertOrUpdate(_stockMapper.StartMapper(integration, itemOutputStock));

                        break;
                    default:
                        return false;
                }
            }
            else
            {
                _epr.InsertOrUpdate(integrationItemsStock);

                if (_conn.Save())
                {
                    switch (integrationItemsStock.TypeIntegration)
                    {
                        case TypeIntegration.InputStock:

                            _itemInputStockApp.InsertOrUpdate(_stockMapper.StartMapper<ItemInputStock>(integrationItemsStock));
                            break;
                        case TypeIntegration.OutputStock:

                            _itemOutputStockApp.InsertOrUpdate(_stockMapper.StartMapper<ItemOutputStock>(integrationItemsStock));
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

        public IQueryable<IntegrationItemsStock> Search(Expression<Func<IntegrationItemsStock, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<IntegrationItemsStock> Search()
        {
            return _epr.Search();
        }
    }
}