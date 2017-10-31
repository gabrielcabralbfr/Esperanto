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
            return pl => pl.CreatedOn;
        }

        /// <summary>
        /// Método para buscar um ProjectLog por ID
        /// </summary>
        /// <param name="companyLogId">ID do CompanyLog a ser buscado</param>
        /// <returns>Retorna true caso encontre um CompanyLog com o ID informado</returns>
        public static Expression<Func<CompanyLog, bool>> GetById(Guid companyLogId)
        {
            return cl => cl.CompanyLogId.Equals(companyLogId);
        }
    }
}
