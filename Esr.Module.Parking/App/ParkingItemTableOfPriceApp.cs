using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Parking.Domain;
using Esr.Module.Parking.Repository;
using System.Data.Entity;

namespace Esr.Module.Parking.App
{
    public class ParkingItemTableOfPriceApp
    {
        private readonly IFactoryCommand<ParkingItemTableOfPrice> _epr;

        public ParkingItemTableOfPriceApp(IFactoryConnection efc)
        {
            _epr = new ParkingItemTableOfPriceRepo(efc);
        }

        public ParkingItemTableOfPrice FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<ParkingItemTableOfPrice> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(ParkingItemTableOfPrice ParkingItemTableOfPrice)
        {
            return _epr.InsertOrUpdate(ParkingItemTableOfPrice);
        }

        public IQueryable<ParkingItemTableOfPrice> Search(Expression<Func<ParkingItemTableOfPrice, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<ParkingItemTableOfPrice> Search()
        {
            return _epr.Search();
        }

        /// <summary>
        /// Cálculo de horas pela tabela de preço.
        /// </summary>
        /// <param name="initialDateTime">Data/Hora Inicial de Entrada no Estacionamento</param>
        /// <param name="finalDateTime">Data/Hora Final de Saída do Estacionamento</param>
        /// <param name="itemTableId">ID do item da tabela de preço.</param>
        /// <returns>Valor Calculado. (Valor pode retornar zero, em caso de periodo de tolerancia ou descontos.)</returns>
        public decimal Calculate(DateTime initialDateTime, DateTime finalDateTime, int itemTableId)
        {
            var itemTable = _epr
                .Search(c => c.Id == itemTableId)
                .Include(c => c.ParkingHoursVariations)
                .Include(c => c.ParkingTableOfPrice).FirstOrDefault();

            if (itemTable == null) return 0;

            // Verifica se está dentro da tolerância
            var horas = Convert.ToDecimal(finalDateTime.Subtract(initialDateTime).TotalHours);
            if (horas <= (itemTable.Tolerance/60))
                return 0;

            var value = decimal.Zero;

            // Verifica hora Fixas.
            if (itemTable.ParkingHoursVariations.Any(c => c.ParkingFixedTime))
            {
                // Verifica se a hora atual está dentro das variações, pega o valor da primeira variação que encontrar.
                var listVariations = itemTable.ParkingHoursVariations.Where(c=>c.ParkingFixedTime).OrderBy(c => c.ParkingStartingTime.Hour); // Ordena da menor para maior hora.
                foreach (var item in listVariations)
                {
                    if ((listVariations.ToList().IndexOf(item) == 0 && horas <= item.ParkingStartingTime.Hour))
                    {
                        value = item.ParkingValue;
                        break;

                    }else if (horas >= item.ParkingStartingTime.Hour)
                    {
                        var intervalHours = horas - Convert.ToDecimal(item.ParkingStartingTime.Hour); // Pega total de hora excedidas.
                        var valueTotalOverTime = Convert.ToInt32(intervalHours) * itemTable.ValueOvertime; // Calcula total de horas execidadas com valor definido para cada hora excedida.
                        var valueTotal = item.ParkingValue + valueTotalOverTime;
                        value = valueTotal;
                    }
                }
            }

            // Verifica hora Fixas.
            if (itemTable.ParkingHoursVariations.Any(c => !c.ParkingFixedTime))
            {
                // Verifica se a hora atual está dentro das variações, pega o valor da primeira variação que encontrar.
                var listVariations = itemTable.ParkingHoursVariations.OrderBy(c => c.ParkingStartingTime.Hour); // Ordena da menor para maior hora.
                foreach (var item in listVariations)
                    if (item.ParkingStartingTime.Hour >= horas && horas <= item.ParkingFinalHour.Hour)
                    {
                        value = item.ParkingValue;
                        break;
                    }

                // Se valor estiver zero indica que total hora não entrou nas variações.
                if (value == 0)
                {
                    var maxTime = itemTable.ParkingHoursVariations.OrderByDescending(c => c.ParkingStartingTime.Hour).FirstOrDefault();
                    var lastValueTime = maxTime.ParkingValue; // Último valor do horário.
                    var intervalHours = horas - Convert.ToDecimal(maxTime.ParkingStartingTime.Hour); // Pega total de hora excedidas.
                    var valueTotalOverTime = intervalHours * itemTable.ValueOvertime; // Calcula total de horas execidadas com valor definido para cada hora excedida.
                    var valueTotal = lastValueTime + valueTotalOverTime;
                    if (valueTotal < itemTable.MaxinumPrice)
                        value = valueTotal;
                    else
                        value = itemTable.MaxinumPrice;
                }
            }

            return value;
        }
    }
}