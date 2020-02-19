using System.Collections.Generic;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using System.Collections;
using Esr.Module.Funerary.App.OrderOfServices;
using Esr.Module.Funerary.Domain.OrderOfServices;
using System;
using Esr.Module.Funerary.App.GroupAttendants;
using System.Data.Entity;
using System.Linq.Expressions;
using Esr.Core.App.Authentication;

namespace Esr.Module.Funerary.Controllers
{
    public class OrderOfServiceController
    {
        private OrderOfServiceApp _OrderOfServiceApp;
        private GroupAttendantApp _GroupAttendantApp;
        private IFactoryConnection _connection;

        public OrderOfServiceController(IFactoryConnection connection)
        {
            _connection = connection;
            _OrderOfServiceApp = new OrderOfServiceApp(connection);
            _GroupAttendantApp = new GroupAttendantApp(connection);
        }

        public OrderOfService FindId(int id)
        {
            return _OrderOfServiceApp.FindId(id);
        }

        public bool Save(OrderOfService OrderOfService)
        {
            _OrderOfServiceApp.InsertOrUpdate(OrderOfService);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _OrderOfServiceApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _OrderOfServiceApp.Remove(_OrderOfServiceApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// OrderOfService List.
        /// </summary>
        /// <returns>{ c.Id, c.NumberOs, c.DateOfIssure, c.Contractor.CorporateName, c.DeadName, TotalProducts = c.OsContractorProducts.Sum(d => d.ValueTotal), 
        /// TotalServices = c.OsContractorServices.Sum(d => d.ValueService)}</returns>
        public IList ListOrderOfService()
        {
            var result = _OrderOfServiceApp.Search()
                .Include(c => c.OsContractorProducts)
                .Include(c => c.OsContractorServices)
                .Select(c => new
                {
                    c.Id,
                    c.NumberOs,
                    c.DateOfIssure,
                    c.Contractor.CorporateName,
                    c.DeadName,
                    Plan = c.Plan.Description
                }).OrderByDescending(c => c.DateOfIssure).Take(100).ToList();

            return result;
        }

        internal bool Autoratized(int id)
        {
            return _GroupAttendantApp.Search(c => c.Attendants.Any(d => d.UserId == id)).Any();
        }

        public bool Remove(Expression<Func<OrderOfService, bool>> expression)
        {
            _OrderOfServiceApp.Remove(_OrderOfServiceApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<OrderOfService, bool>> expression)
        {
            return _OrderOfServiceApp.Search(expression).ToList();
        }

        //TotalOs = (c.OsContractorProducts.Any() ? c.OsContractorProducts.Sum(d => d.ValueTotal) : 0) + 
        //           (c.OsContractorServices.Any() ? c.OsContractorServices.Sum(d => d.ValueService) : 0) +
        //           (c.OsProducts.Any() ? c.OsProducts.Sum(d => d.ValueTotal) : 0) +
        //           (c.OsServices.Any() ? c.OsServices.Sum(d => d.ValueService) : 0) +
        //           (c.OsServices.Any() ? c.OsServices.Sum(d => d.ValueService) : 0)

        public object QueryCapaOrdemServico(Expression<Func<OrderOfService, bool>> expression)
        {
            var vehicle = new OsVehicleApp(_connection);
            var OsContractorServices = new OsContractorServiceApp(_connection);
            var Contractor = new PersonApp(_connection);
            var osServiceapp = new OsServiceApp(_connection);
            var osProdutos = new OsProductApp(_connection);

            var osService = _OrderOfServiceApp.Search(expression)
                .Include(c => c.OsVehicles)
                .Include(c => c.OsContractorServices)
                .Include(c => c.Contractor)
                .Include(c => c.OsProducts)
                .Include(c => c.OsServices);

            var result = (from objeto in osService
                          select new
                          {
                              objeto.Id,
                              objeto.NumberOs,
                              DateOs = objeto.DateOfIssure,
                              TimeOs = objeto.DateOfIssure,
                              objeto.DeadName,
                              objeto.ResponsibleName,
                              objeto.PlaceOfDead,
                              objeto.BurialPlace,
                              objeto.WakeLocation,
                              objeto.Phone1,
                              objeto.Phone2,
                              PlanDescription = objeto.Plan.Description,
                              objeto.Sinister,
                              DateOfDead = objeto.DateOfDead,
                              BurialDate = objeto.BurialDate,
                              BurialTime = objeto.BurialTime,
                              objeto.GeneralInformation,
                              objeto.Contractor.PersonName,
                              objeto.Contractor.Cnpj,
                              ContractorId = objeto.Contractor.Id,
                              CodigoContratada = objeto.Contractor.Id,
                              ContractorName = objeto.Contractor.PersonName,
                              ComercialPhone = objeto.Contractor.CommercialPhone,
                              objeto.Contractor.CellPhone,
                              ValueTotalServices = (
                                              (objeto.OsServices.Any() ? objeto.OsServices.Sum(c => c.ValueService) : 0) +
                                              (objeto.OsProducts.Any() ? objeto.OsProducts.Sum(c => c.ValueTotal) : 0) +
                                              (objeto.OsVehicles.Any() ? objeto.OsVehicles.Sum(C => C.ValueService) : 0) +
                                              (objeto.OsContractorServices.Any() ? objeto.OsContractorServices.Sum(c => c.ValueService) : 0)
                                          ),
                              objeto.Contractor.Street,
                              objeto.Contractor.Neighborhood,
                              objeto.Contractor.City.CityName,
                              StateInitials = objeto.Contractor.State.Initials,
                              objeto.Contractor.ZipCode
                          }
                          );

            //var resultLinq = (from objeto in osService
            //                  join t2 in vehicle.Search() on objeto.Id equals t2.OrderOfServiceId into t6
            //                  join t3 in OsContractorServices.Search() on objeto.Id equals t3.OrderOfServiceId into t7
            //                  join t5 in Contractor.Search() on objeto.Contractor.Id equals t5.Id into t9
            //                  join t10 in osProdutos.Search() on objeto.Id equals t10.OrderOfServiceId into t11
            //                  join t12 in osServiceapp.Search() on objeto.Id equals t12.OrderOfServiceId into t13
            //                  from t2 in t6.DefaultIfEmpty()
            //                  from t3 in t7.DefaultIfEmpty()
            //                  from t5 in t9.DefaultIfEmpty()
            //                  from t10 in t11.DefaultIfEmpty()
            //                  from t12 in t13.DefaultIfEmpty()
            //                  select new
            //                  {
            //                      objeto.Id,
            //                      objeto.NumberOs,
            //                      DateOs = objeto.DateOfIssure,
            //                      TimeOs = objeto.DateOfIssure,
            //                      objeto.DeadName,
            //                      objeto.ResponsibleName,
            //                      objeto.PlaceOfDead,
            //                      objeto.BurialPlace,
            //                      objeto.WakeLocation,
            //                      objeto.Phone1,
            //                      objeto.Phone2,
            //                      PlanDescription = objeto.Plan.Description,
            //                      objeto.Sinister,
            //                      DateOfDead = objeto.DateOfDead,
            //                      BurialDate = objeto.BurialDate,
            //                      BurialTime = objeto.BurialTime,
            //                      objeto.GeneralInformation,
            //                      objeto.Contractor.PersonName,
            //                      objeto.Contractor.Cnpj,
            //                      ContractorId = objeto.Contractor.Id,
            //                      t2.Drive.DriveName,
            //                      t2.VehiclePlate.Plate,
            //                      ServiceDescription = t2.Service.Description,
            //                      CodigoContratada = t3.Contractor.Id,
            //                      ContractorName = t3.Contractor.PersonName,
            //                      ComercialPhone = t3.Contractor.CommercialPhone,
            //                      t3.Contractor.CellPhone,
            //                      ValueTotalServices = (
            //                                  (objeto.OsServices.Any() ? objeto.OsServices.Sum(c => c.ValueService) : 0) +
            //                                  (objeto.OsProducts.Any() ? objeto.OsProducts.Sum(c => c.ValueTotal) : 0) +
            //                                  (objeto.OsVehicles.Any() ? objeto.OsVehicles.Sum(C => C.ValueService) : 0) +
            //                                  (objeto.OsContractorServices.Any() ? objeto.OsContractorServices.Sum(c => c.ValueService) : 0)
            //                              ),
            //                      t3.Contractor.Street,
            //                      t3.Contractor.Neighborhood,
            //                      t3.Contractor.City.CityName,
            //                      StateInitials = t3.Contractor.State.Initials,
            //                      t3.Contractor.ZipCode
            //                  });

            return result.ToList();
        }

        public object QueryMotoristaServico(Expression<Func<OrderOfService, bool>> expression)
        {
            var vehicle = new OsVehicleApp(_connection);

            var osService = _OrderOfServiceApp.Search(expression)
                .Include(c => c.OsVehicles);

            return (from t2 in osService.SelectMany(c => c.OsVehicles)
                    select new
                    {
                        t2.Drive.DriveName,
                        t2.VehiclePlate.Plate,
                        ServiceDescription = t2.Service.Description
                    }).ToList();

            //return (from objeto in osService
            //        join t2 in vehicle.Search() on objeto.Id equals t2.OrderOfServiceId into t5
            //        from t2 in t5.DefaultIfEmpty()
            //        select new
            //        {
            //            t2.Drive.DriveName,
            //            t2.VehiclePlate.Plate,
            //            ServiceDescription = t2.Service.Description
            //        }).ToList();
        }

        public object QueryContratadaServico(Expression<Func<OrderOfService, bool>> expression)
        {
            var OsContractorServices = new OsContractorServiceApp(_connection);

            var osService = _OrderOfServiceApp.Search(expression)
                .Include(c => c.OsContractorServices);

            return (from t3 in osService.SelectMany(c => c.OsContractorServices)
                    select new
                    {
                        ContractorId = t3.Contractor.Id,
                        ContractorName = t3.Contractor.PersonName,
                        t3.Contractor.CommercialPhone,
                        t3.Contractor.CellPhone,
                        Historico = t3.HistoricalService,
                        ValueService = t3.ValueService
                    }).ToList();

            //return (from objeto in osService
            //        join t3 in OsContractorServices.Search() on objeto.Id equals t3.OrderOfServiceId into t6
            //        from t3 in t6.DefaultIfEmpty()
            //        select new
            //        {
            //            ContractorId = t3.Contractor.Id,
            //            ContractorName = t3.Contractor.PersonName,
            //            t3.Contractor.CommercialPhone,
            //            t3.Contractor.CellPhone,
            //            Historico = t3.HistoricalService,
            //            ValueService = t3.ValueService
            //        }).ToList();
        }
    }
}