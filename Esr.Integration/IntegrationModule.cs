using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Stock.App.Managements;

namespace Esr.Integration
{
    public class IntegrationModule
    {
        public StockManagement StockIntegration { get; }

        public IntegrationModule(IFactoryConnection efc)
        {
            StockIntegration = new StockManagement(efc);
        }
    }
}