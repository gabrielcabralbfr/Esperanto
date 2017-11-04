using Esperanto.Domain.Entities;
using System;
using System.Linq.Expressions;


namespace Esperanto.Domain.Specs
{
   public class CompanyLogSpecs
    {
        /// <summary>
        /// Método para ordenação dos Logs de Company por data de criação
        /// </summary>
        /// <returns>Retorna uma Expression para ordenação por data de criação</returns>
        public static Expression<Func<CompanyLog, DateTime>> OrderByDefault()
        {
            return cl => cl.CreatedOn;
        }

        /// <summary>
        /// Método para obter os Logs de Company por delimitação de período inicial e período final
        /// </summary>
        /// <param name="starDate">Período inicial</param>
        /// <param name="endDate">Período final</param>
        /// <returns>Retorna todos os Logs de Company dentro do período especificado</returns>
        public static Expression<Func<CompanyLog, bool>> Get(DateTime startDate, DateTime endDate)
        {
            return cl => cl.CreatedOn >= startDate && cl.CreatedOn <= endDate;
        }
    }
}
