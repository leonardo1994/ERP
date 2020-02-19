using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Funerary.Domain.OrderOfServices;
using Esr.Module.Funerary.Repository.OrderOfServices;
using Esr.Core.Domain.Other;
using Esr.Core.Domain.Authentication;
using Esr.Module.Stock.App.Integration;
using Esr.Module.Funerary.MapperConfig;
using Esr.Module.Funerary.Domain.Integration.Stock;

namespace Esr.Module.Funerary.App.OrderOfServices
{
    public class OsProductApp
    {
        private readonly IFactoryConnection _conn;
        private readonly IFactoryCommand<OsProduct> _epr;
        private readonly OrderOfServiceApp _osApp;
        private readonly IntegrationCapeStockApp _integrationCapeStockApp;
        private readonly IntegrationItemsStockApp _integrationItemsStockApp;

        public OsProductApp(IFactoryConnection efc)
        {
            _epr = new OsProductRepo(efc);
            _osApp = new OrderOfServiceApp(efc);
            _integrationCapeStockApp = new IntegrationCapeStockApp(efc);
            _integrationItemsStockApp = new IntegrationItemsStockApp(efc);
            _conn = efc;
        }

        public OsProduct FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<OsProduct> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(OsProduct OsProduct)
        {
            try
            {
                _epr.InsertOrUpdate(OsProduct);

                return _conn.Save();

                //if (_conn.Save())
                //{
                //    //var os = _osApp.FindId(OsProduct.OrderOfServiceId);
                //    //var mapper = new FuneraryMapper();

                //    //if (_integrationCapeStockApp.InsertOrUpdate(mapper.StartMapper(os)))
                //    //{
                //    //    var capaId = _integrationCapeStockApp.GetIdStock(c => (c as OutputStockFunerary).OrderOfServiceId == os.Id, Stock.Domain.Integration.TypeIntegration.OutputStock);
                //    //    var integrationId = _integrationCapeStockApp.Search(c => (c as OutputStockFunerary).OrderOfServiceId == os.Id).FirstOrDefault().Id;

                //    //    var itemIntegration = mapper.StartMapper(OsProduct);
                //    //    itemIntegration.IntegrationCapeStockId = integrationId;

                //    //    itemIntegration.OutputStockId = capaId;

                //    //    return _integrationItemsStockApp.InsertOrUpdate(itemIntegration);
                //    //}
                //}
                //return false;
            }
            catch (Exception ex)
            {
                GlobalUser.Logs.Add(new Log()
                {
                    ProcessStatus = ProcessStatus.Error,
                    Description = ex.Message
                });
                return false;
            }
        }

        public IQueryable<OsProduct> Search(Expression<Func<OsProduct, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<OsProduct> Search()
        {
            return _epr.Search();
        }
    }
}