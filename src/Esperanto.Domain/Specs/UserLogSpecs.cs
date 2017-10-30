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

    }
}
