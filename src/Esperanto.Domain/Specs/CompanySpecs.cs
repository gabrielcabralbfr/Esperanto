using Esperanto.Domain.Entities;
using Esperanto.Domain.Enums.Company;
using System;
using System.Linq.Expressions;


namespace Esperanto.Domain.Specs
{
    public class CompanySpecs
    {
        /// <summary>
        /// Método para ordenar Company por nome
        /// </summary>
        /// <returns>Retorna uma Expression do tipo string para ordenação por Nome</returns>
        public static Expression<Func<Company, string>> OrderByDefault()
        {
            return c => c.Name;
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

        /// <summary>
        /// Método para buscar Companies pelo ID
        /// </summary>
        /// <param name="companyId">ID da Company a ser buscado</param>
        /// <returns>Retorna a Company com o ID informado</returns>
        public static Expression<Func<Company, bool>> GetById(Guid companyId)
        {
            return c => c.CompanyId.Equals(companyId);
        }
    }
}
