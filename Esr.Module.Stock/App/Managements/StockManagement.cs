using Esr.Core.Domain.Other;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.App.StockItems;
using Esr.Module.InitialRegistration.App.UnitMeasureConversions;
using Esr.Module.InitialRegistration.App.UnitMeasures;
using Esr.Module.Stock.App.InputsOutputs;
using System.Collections.Generic;

namespace Esr.Module.Stock.App.Managements
{
    /// <summary>
    /// Classe responsável em gerenciar o Stock
    /// </summary>
    public class StockManagement
    {
        #region Declaração de Variáveis
        private readonly IFactoryConnection connection;
        private ItemInputStockApp _itemInputStockApp;
        private ItemOutputStockApp _itemOutputStockApp;
        private StockItemApp _stockItemApp;
        private LocalStockApp _localStockApp;
        private UnitMeasureConversionApp _unitMeasureConversionApp;
        public IList<Log> Logs { get; set; }
        #endregion

        public StockManagement(IFactoryConnection factoryConnection)
        {
            connection = factoryConnection;
            Logs = new List<Log>();
        }

        /// <summary>
        /// Saldo Disponível
        /// </summary>
        /// <param name="stockItemId">ID do item de estoque.</param>
        /// <param name="localStockId">ID do local de estoque.</param>
        /// <returns></returns>
        public decimal BalanceAvailable(int stockItemId, int localStockId, int unitMeasurId)
        {
            _itemInputStockApp = new ItemInputStockApp(connection);
            _itemOutputStockApp = new ItemOutputStockApp(connection);
            _stockItemApp = new StockItemApp(connection);
            _localStockApp = new LocalStockApp(connection);
            _unitMeasureConversionApp = new UnitMeasureConversionApp(connection);

            var qtdInput = _itemInputStockApp.GetQuantityTotal(stockItemId, localStockId);
            var qtdOutput = _itemOutputStockApp.GetQuantityTotal(stockItemId, localStockId);
            var stockItem = _stockItemApp.FindId(stockItemId);

            return _unitMeasureConversionApp.Convert(stockItem.UnitMeasureId, unitMeasurId, stockItemId, stockItem.FamilyId, qtdInput - qtdOutput);
        }

        /// <summary>
        /// Verifica as configurações do item para Saída.
        /// </summary>
        /// <param name="stockItemId">ID item de estoque.</param>
        /// <param name="localStockId">ID do local de estoque.</param>
        /// <param name="Qtd">Quantidade que saiara do estoque.</param>
        /// <param name="itemOutputStockId">ID do item do movimento de estoque, calculo do estoque irá desconsiderar saída existente no saldo. Parametro não obrigatório.</param>
        /// <returns></returns>
        public bool ValidItem(int stockItemId, int localStockId, int unitMeasurId, decimal qtd, int itemOutputStockId = 0)
        {
            _itemInputStockApp = new ItemInputStockApp(connection);
            _itemOutputStockApp = new ItemOutputStockApp(connection);
            _unitMeasureConversionApp = new UnitMeasureConversionApp(connection);
            _stockItemApp = new StockItemApp(connection);
            _localStockApp = new LocalStockApp(connection);

            var stockItem = _stockItemApp.FindId(stockItemId);
            var localStock = _localStockApp.FindId(localStockId);

            var qtdOldOutput = _unitMeasureConversionApp
                .Convert(
                            stockItem.UnitMeasureId, 
                            unitMeasurId, 
                            stockItemId, 
                            stockItem.FamilyId, 
                            _itemOutputStockApp
                                .FindId(itemOutputStockId)?.StandardQuantity ?? 0);

            if (stockItem.AllowsUnavaliableMovement) return true;

            var balance = BalanceAvailable(stockItemId, localStockId, unitMeasurId) + qtdOldOutput;

            if (stockItem.EvaluateAvailability)
                if (balance < qtd)
                {
                    Logs.Add(new Log
                    {
                        Description = "Não é permitido movimentar item sem disponibilidade.",
                        ProcessStatus = ProcessStatus.Alert,
                        Identification = stockItem.Code + " - " + stockItem.Description
                    });
                    return false;
                }

            if (stockItem.NotNegativeBalance && balance < 0)
            {
                Logs.Add(new Log
                {
                    Description = "Não é permitido movimentar item com saldo negativo.",
                    ProcessStatus = ProcessStatus.Alert,
                    Identification = stockItem.Code + " - " + stockItem.Description
                });
                return false;
            }

            return true;
        }
    }
}