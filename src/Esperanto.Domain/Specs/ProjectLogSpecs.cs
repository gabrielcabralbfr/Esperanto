using Esperanto.Domain.Entities;
using System;
using System.Linq.Expressions;


namespace Esperanto.Domain.Specs
{
    public class ProjectLogSpecs
    {
        /// <summary>
        /// Método para ordenação dos Logs de Projeto por data de criação
        /// </summary>
        /// <returns>Retorna uma Expression para ordenação por data de criação</returns>
        public static Expression<Func<ProjectLog, DateTime>> OrderByDefault()
        {
            return pl => pl.CreatedOn;
        }

        /// <summary>
        /// Método para obter os Logs de Projeto por delimitação de período inicial e período final
        /// </summary>
        /// <param name="starDate">Período inicial</param>
        /// <param name="endDate">Período final</param>
        /// <returns>Retorna todos os Logs de Projeto dentro do período especificado</returns>
        public static Expression<Func<ProjectLog, bool>> Get(DateTime startDate, DateTime endDate)
        {
            return pl => pl.CreatedOn >= startDate && pl.CreatedOn <= endDate;
        }
    }
}
