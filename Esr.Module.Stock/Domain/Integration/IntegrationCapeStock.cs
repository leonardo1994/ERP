using Esr.Core.Domain.ClassBase;
using System;
using Esr.Core.Domain.Authentication;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;

namespace Esr.Module.Stock.Domain.Integration
{
    /// <summary>
    /// Realiza a integração com Estoque.
    /// </summary>
    public class IntegrationCapeStock : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }
        public bool Integration { get; set; }

        [NotMapped]
        public string Code { get; set; }

        [NotMapped]
        public DateTime DateInput { get; set; }

        [NotMapped]
        public int? PersonId { get; set; }

        [NotMapped]
        public int TypeIntegrationId { get { return (int)TypeIntegration; } set { TypeIntegration = (TypeIntegration)value;  } }

        [NotMapped]
        public TypeIntegration TypeIntegration { get; set; }

        /// <summary>
        /// Nome do documento de origem.
        /// </summary>
        public string Origin { get; set; }

        public virtual Expression<Func<IntegrationCapeStock, bool>> GetExpressionByRelation()
        {
            Expression<Func<IntegrationCapeStock, bool>> expression;
            return expression = xx => xx.Id == Id;
        }
    }

    public enum TypeIntegration
    {
        InputStock,
        OutputStock
    }
}