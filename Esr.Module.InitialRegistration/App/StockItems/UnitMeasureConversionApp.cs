using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.Domain.StockItems;
using Esr.Module.InitialRegistration.Repository.StockItems;
using Esr.Core.Domain.Other;
using Esr.Module.InitialRegistration.App.UnitMeasures;
using Esr.Module.InitialRegistration.App.StockItems;
using Esr.Core.Domain.EnumBase;

namespace Esr.Module.InitialRegistration.App.UnitMeasureConversions
{
    public class UnitMeasureConversionApp
    {
        private readonly IFactoryCommand<UnitMeasureConversion> _epr;
        private readonly UnitMeasureApp _unitMeasureApp;
        private readonly StockItemApp _stockItemApp;
        private readonly FamilyApp _familyApp;
        public List<Log> Logs { get; set; }

        public UnitMeasureConversionApp(IFactoryConnection efc)
        {
            _epr = new UnitMeasureConversionRepo(efc);
            _unitMeasureApp = new UnitMeasureApp(efc);
            _stockItemApp = new StockItemApp(efc);
            _familyApp = new FamilyApp(efc);
            Logs = new List<Log>();
        }

        public UnitMeasureConversion FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<UnitMeasureConversion> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(UnitMeasureConversion UnitMeasureConversion)
        {
            return _epr.InsertOrUpdate(UnitMeasureConversion);
        }

        public IQueryable<UnitMeasureConversion> Search(Expression<Func<UnitMeasureConversion, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<UnitMeasureConversion> Search()
        {
            return _epr.Search();
        }

        /// <summary>
        /// Conversão de unidade de medida.
        /// </summary>
        /// <param name="currentUnitOfMeasureId">Unidade de Medida base.</param>
        /// <param name="unitOfMeasureConversionId">Unidade de medida que será convertida.</param>
        /// <param name="StockItemId">ID do item de estoque, para avaliar se existe conversão específica para o item.</param>
        /// <param name="familyId">ID da familia do estoque, para avaliar se existe conversão específicoa para familia.</param>
        /// <param name="quantity">Quantidade a ser convertida.</param>
        /// <returns>Valor convertido, se retornar zero (pode ter ocorrido algum problema na conversão.)</returns>
        public decimal Convert(int currentUnitOfMeasureId, int unitOfMeasureConversionId, int? StockItemId, int? familyId, decimal quantity)
        {

            if (quantity == 0) return quantity;

            var currentUM = _unitMeasureApp.FindId(currentUnitOfMeasureId);
            var uMConversion = _unitMeasureApp.FindId(unitOfMeasureConversionId);
            decimal factor = 0;
            TypeOperation typeOperation = 0;

            var conversions = _epr.Search(c => c.FirstUnitMeasureId == currentUnitOfMeasureId);

            if (conversions.Any())
            {
                if (conversions.Any(c => c.SecondUnitMeasureId == unitOfMeasureConversionId))
                {
                    #region Avalia conversões da unidade de medida para um item específico
                    if (StockItemId.HasValue)
                    {
                        var stockItem = _stockItemApp.FindId(StockItemId.Value);

                        var stockItemConversion = conversions.SingleOrDefault(c => c.StockItemId == StockItemId && c.SecondUnitMeasureId == unitOfMeasureConversionId);

                        if (stockItemConversion != null)
                        {
                            typeOperation = stockItemConversion.TypeOperation;
                            factor = stockItemConversion.ConversionFactor;
                        }
                        else
                        {

                            Logs.Add(new Log()
                            {
                                Identification = $"Unidade de Medida '{ currentUM.Initials }'",
                                Description = $"Unidade de Medida '{ currentUM.Initials }' não tem conversão para Unidade de Medida '{ uMConversion.Initials }', para o item '{ stockItem.Code + " - " + stockItem.Description }'",
                                ProcessStatus = ProcessStatus.Error
                            });
                            return 0;

                        }
                    }
                    #endregion
                    #region Avalia conversões da unidade de medida para um familia específica
                    else if (familyId.HasValue)
                    {
                        var family = _familyApp.FindId(familyId.Value);

                        var familyConversion = conversions.SingleOrDefault(c => c.FamilyId == familyId && c.SecondUnitMeasureId == unitOfMeasureConversionId);

                        if (familyConversion != null)
                        {
                            typeOperation = familyConversion.TypeOperation;
                            factor = familyConversion.ConversionFactor;
                        }
                        else
                        {
                            Logs.Add(new Log()
                            {
                                Identification = $"Unidade de Medida '{ currentUM.Initials }'",
                                Description = $"Unidade de Medida '{ currentUM.Initials }' não tem conversão para Unidade de Medida '{ uMConversion.Initials }', para a Familia '{ family.FamilyCode + " - " + family.FamilyName }'",
                                ProcessStatus = ProcessStatus.Error
                            });
                            return 0;
                        }
                    }
                    #endregion
                    #region Avalia converão de unidade de medida
                    else
                    {
                        var uMconversion = conversions.SingleOrDefault(c => c.SecondUnitMeasureId == unitOfMeasureConversionId && !c.StockItemId.HasValue && !c.FamilyId.HasValue);
                        typeOperation = uMconversion.TypeOperation;
                        factor = uMconversion.ConversionFactor;
                    }
                    #endregion
                }
                else
                {
                    Logs.Add(new Log()
                    {
                        Identification = $"Unidade de Medida '{ currentUM.Initials }'",
                        Description = $"Unidade de Medida '{ currentUM.Initials }' não tem conversão para Unidade de Medida '{ uMConversion.Initials }'",
                        ProcessStatus = ProcessStatus.Error
                    });
                    return 0;
                }
            }
            else
            {
                Logs.Add(new Log()
                {
                    Identification = $"Unidade de Medida '{ currentUM.Initials }'",
                    Description = $"Unidade de Medida '{ currentUM.Initials }' não tem nenhuma conversão cadastrada",
                    ProcessStatus = ProcessStatus.Error
                });
                return 0;
            }

            switch (typeOperation)
            {
                case TypeOperation.Division:
                    return quantity / factor;
                case TypeOperation.Sum:
                    return quantity + factor;
                case TypeOperation.Subtraction:
                    return quantity - factor;
                case TypeOperation.Multiplication:
                    return quantity * factor;
                case TypeOperation.SubtractionPorcent:
                    return quantity - (quantity / 100) * factor;
                case TypeOperation.AditionalPorcent:
                    return quantity + (quantity / 100) * factor;
                case TypeOperation.PorcentValue:
                    return (quantity / 100) * factor;
                case TypeOperation.SubtractionInversion:
                    return factor - quantity;
                default:
                    return 0;
            }
        }
    }
}