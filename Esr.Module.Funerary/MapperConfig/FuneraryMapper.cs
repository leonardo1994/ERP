using AutoMapper;
using Esr.Module.Funerary.Domain.Integration.Stock;
using Esr.Module.Funerary.Domain.OrderOfServices;
using Esr.Module.Stock.Domain.Integration;
using System;

namespace Esr.Module.Funerary.MapperConfig
{
    public class FuneraryMapper
    {
        public OutputStockFunerary StartMapper(OrderOfService orderOfService)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<OrderOfService, OutputStockFunerary>()
                    .ForMember(x => x.CompanyControl, opt => opt.Ignore())
                    .ForMember(x => x.CompanyControlId, opt => opt.Ignore())
                    .ForMember(x => x.DateRegistration, opt => opt.Ignore())
                    .ForMember(x => x.DateUpdate, opt => opt.Ignore())
                    .ForMember(x => x.Id, opt => opt.Ignore())
                    .ForMember(x => x.Integration, opt => opt.Ignore())
                    .ForMember(x => x.Status, opt => opt.Ignore())
                    .ForMember(x => x.UserControl, opt => opt.Ignore())
                    .ForMember(x => x.UserControlId, opt => opt.Ignore())
                    .ForMember(x => x.OrderOfServiceId, opt => opt.MapFrom(x => x.Id))
                    .ForMember(x => x.DateInput, opt => opt.MapFrom(x => x.DateOfIssure))
                    .ForMember(x => x.PersonId, opt => opt.MapFrom(x => x.ContractorId))
                    .ForMember(x => x.TypeIntegration, opt => opt.MapFrom(x => TypeIntegration.OutputStock))
                    .ForMember(x => x.TypeIntegrationId, opt => opt.MapFrom(x => (int)TypeIntegration.OutputStock))
                    .ForMember(x => x.Code, opt => opt.MapFrom(x => x.NumberOs))
                    .ForMember(x => x.Origin, opt => opt.MapFrom(x => typeof(OrderOfService).Name));
            });

            IMapper mapper = config.CreateMapper();

            var obj = mapper.Map<OrderOfService, OutputStockFunerary>(orderOfService);

            return obj;
        }

        public ItemOutputStockFunerary StartMapper(OsProduct osProduct)
        {
            var config = new MapperConfiguration(cfg => {
            cfg.CreateMap<OsProduct, ItemOutputStockFunerary>()
                .ForMember(x => x.CompanyControl, opt => opt.Ignore())
                .ForMember(x => x.CompanyControlId, opt => opt.Ignore())
                .ForMember(x => x.DateRegistration, opt => opt.Ignore())
                .ForMember(x => x.DateUpdate, opt => opt.Ignore())
                .ForMember(x => x.Id, opt => opt.Ignore())
                .ForMember(x => x.Integration, opt => opt.Ignore())
                .ForMember(x => x.Status, opt => opt.Ignore())
                .ForMember(x => x.UserControl, opt => opt.Ignore())
                .ForMember(x => x.UserControlId, opt => opt.Ignore())
                .ForMember(x => x.OsProductId, opt => opt.MapFrom(x => x.Id))
                .ForMember(x => x.TypeIntegration, opt => opt.MapFrom(x => TypeIntegration.OutputStock))
                .ForMember(x => x.TypeIntegrationId, opt => opt.MapFrom(x => (int)TypeIntegration.OutputStock))
                .ForMember(x => x.LocalStockId, opt => opt.MapFrom(x => x.LocalStockId))
                .ForMember(x => x.LocalStockId, opt => opt.MapFrom(x => x.LocalStockId))
                .ForMember(x => x.Quantity, opt => opt.MapFrom(x => x.Quantity))
                .ForMember(x => x.UnitaryValue, opt => opt.MapFrom(x => x.UnitaryValue))
                .ForMember(x => x.Total, opt => opt.MapFrom(x => x.ValueTotal))
                .ForMember(x => x.UnitMeasureId, opt => opt.MapFrom(x => x.UnitMeasureId))
                .ForMember(x => x.Date, opt => opt.MapFrom(x => DateTime.Now))
                .ForMember(x => x.Origin, opt => opt.MapFrom(x => typeof(OsProduct).Name));
            });

            IMapper mapper = config.CreateMapper();

            var obj = mapper.Map<OsProduct, ItemOutputStockFunerary>(osProduct);

            return obj;
        }
    }
}