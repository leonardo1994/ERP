using AutoMapper;
using Esr.Module.Stock.Domain.Integration;
using Esr.Core.Domain.ClassBase;
using AutoMapper.Configuration;

namespace Esr.Module.Stock.MapperConfig
{
    public class StockMapper
    {
        public T StartMapper<T>(IntegrationCapeStock integration) where T : class, IEntityBase
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<IntegrationCapeStock, T>()
                    .ForMember(x => x.CompanyControl, opt => opt.Ignore())
                    .ForMember(x => x.CompanyControlId, opt => opt.Ignore())
                    .ForMember(x => x.DateRegistration, opt => opt.Ignore())
                    .ForMember(x => x.DateUpdate, opt => opt.Ignore())
                    .ForMember(x => x.Id, opt => opt.Ignore())
                    .ForMember(x => x.Integration, opt => opt.UseValue(true))
                    .ForMember(x => x.Integration, opt => opt.Ignore())
                    .ForMember(x => x.Status, opt => opt.Ignore())
                    .ForMember(x => x.UserControl, opt => opt.Ignore())
                    .ForMember(x => x.UserControlId, opt => opt.Ignore());
            });

            IMapper mapper = config.CreateMapper();

            var obj = mapper.Map<IntegrationCapeStock, T>(integration); 

            var propertyIntegrationCapeStockId = typeof(T).GetProperty("IntegrationCapeStockId");

            if (propertyIntegrationCapeStockId != null)
                propertyIntegrationCapeStockId.SetValue(obj, integration.Id);

            return obj;
        }

        public T StartMapper<T>(IntegrationCapeStock integration, T destination) where T : class, IEntityBase
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<IntegrationCapeStock, T>()
                    .ForMember(x => x.CompanyControl, opt => opt.Ignore())
                    .ForMember(x => x.CompanyControlId, opt => opt.Ignore())
                    .ForMember(x => x.DateRegistration, opt => opt.Ignore())
                    .ForMember(x => x.DateUpdate, opt => opt.Ignore())
                    .ForMember(x => x.Id, opt => opt.Ignore())
                    .ForMember(x => x.Integration, opt => opt.Ignore())
                    .ForMember(x => x.Status, opt => opt.Ignore())
                    .ForMember(x => x.UserControl, opt => opt.Ignore())
                    .ForMember(x => x.Integration, opt => opt.UseValue(true))
                    .ForMember(x => x.UserControlId, opt => opt.Ignore());
            });

            IMapper mapper = config.CreateMapper();

            var obj = mapper.Map(integration, destination);

            var propertyIntegrationCapeStockId = typeof(T).GetProperty("IntegrationCapeStockId");

            if (propertyIntegrationCapeStockId != null)
                propertyIntegrationCapeStockId.SetValue(obj, integration.Id);

            return obj;
        }

        public T StartMapper<T>(IntegrationItemsStock integration) where T : class, IEntityBase
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<IntegrationItemsStock, T>()
                    .ForMember(x => x.CompanyControl, opt => opt.Ignore())
                    .ForMember(x => x.CompanyControlId, opt => opt.Ignore())
                    .ForMember(x => x.DateRegistration, opt => opt.Ignore())
                    .ForMember(x => x.DateUpdate, opt => opt.Ignore())
                    .ForMember(x => x.Id, opt => opt.Ignore())
                    .ForMember(x => x.Integration, opt => opt.Ignore())
                    .ForMember(x => x.Status, opt => opt.Ignore())
                    .ForMember(x => x.Integration, opt => opt.UseValue(true))
                    .ForMember(x => x.UserControl, opt => opt.Ignore())
                    .ForMember(x => x.UserControlId, opt => opt.Ignore());
            });

            IMapper mapper = config.CreateMapper();

            var obj = mapper.Map<IntegrationItemsStock, T>(integration);

            var propertyIntegrationItemsStockId = typeof(T).GetProperty("IntegrationItemsStockId");

            if (propertyIntegrationItemsStockId != null)
                propertyIntegrationItemsStockId.SetValue(obj, integration.Id);

            return obj;
        }

        public T StartMapper<T>(IntegrationItemsStock integration, T destination) where T : class, IEntityBase
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<IntegrationItemsStock, T>()
                    .ForMember(x => x.CompanyControl, opt => opt.Ignore())
                    .ForMember(x => x.CompanyControlId, opt => opt.Ignore())
                    .ForMember(x => x.DateRegistration, opt => opt.Ignore())
                    .ForMember(x => x.DateUpdate, opt => opt.Ignore())
                    .ForMember(x => x.Id, opt => opt.Ignore())
                    .ForMember(x => x.Integration, opt => opt.UseValue(true))
                    .ForMember(x => x.Integration, opt => opt.Ignore())
                    .ForMember(x => x.Status, opt => opt.Ignore())
                    .ForMember(x => x.UserControl, opt => opt.Ignore())
                    .ForMember(x => x.UserControlId, opt => opt.Ignore());
            });

            IMapper mapper = config.CreateMapper();

            var obj = mapper.Map(integration, destination);

            var propertyIntegrationItemsStockId = typeof(T).GetProperty("IntegrationItemsStockId");

            if (propertyIntegrationItemsStockId != null)
                propertyIntegrationItemsStockId.SetValue(obj, integration.Id);

            return obj;
        }
    }
}