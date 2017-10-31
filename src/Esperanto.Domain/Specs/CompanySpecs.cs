using Esperanto.Domain.Entities;
using Esperanto.Domain.Enums.Company;
using System;
using System.Linq.Expressions;


namespace Esperanto.Domain.Specs
{
    public class CompanySpecs
    {
        /// <summary>
        /// Método para ordenar Company por data de criação
        /// </summary>
        /// <returns>Retorna uma Expression do tipo DateTime para ordenação por data de criação</returns>
        public static Expression<Func<Company, DateTime>> OrderByDefault()
        {
            return c => c.CreatedOn;
        }

        /// <summary>
        /// Método para obter Companies ativas
        /// </summary>
        /// <returns>retorna Companies ativas</returns>
        public static Expression<Func<Company, bool>> GetActives()
        {
            return c => c.CompanyStatus.Equals(ECompanyStatus.Active);
        }

        /// <summary>
        /// Método para obter Companies inativas
        /// </summary>
        /// <returns>retorna Companies inativas</returns>
        public static Expression<Func<Company, bool>> GetInactives()
        {
            return c => c.CompanyStatus.Equals(ECompanyStatus.Inactive);
        }

        /// <summary>
        /// Método para buscar Companies pelo Nome
        /// </summary>
        /// <param name="name">Nome da Company a ser buscado</param>
        /// <returns>Retorna a Company com o nome informado</returns>
        public static Expression<Func<Company, bool>> GetByName(string name)
        {
            return c => c.Name.Equals(name);
        }
    }
}
