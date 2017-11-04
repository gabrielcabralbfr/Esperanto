using Esperanto.Domain.Entities;
using System;
using System.Linq.Expressions;


namespace Esperanto.Domain.Specs
{
    public class UserLogSpecs
    {
        /// <summary>
        /// Método para ordernação dos Logs pela data de criação
        /// </summary>
        /// <returns>Retorna os Logs de usuário ordenados por data de criação</returns>
        public static Expression<Func<UserLog, DateTime>> OrderByDefault()
        {
            return ul => ul.CreatedOn;
        }

        /// <summary>
        /// Método para obter os Logs de Usuário por delimitação de período inicial e período final
        /// </summary>
        /// <param name="starDate">Período inicial</param>
        /// <param name="endDate">Período final</param>
        /// <returns>Retorna todos os Logs de Usuário dentro do período especificado</returns>
        public static Expression<Func<UserLog, bool>> Get(DateTime startDate, DateTime endDate)
        {
            return ul => ul.CreatedOn >= startDate && ul.CreatedOn <= endDate;
        }

    }
}
