using Esperanto.Domain.Entities;
using Esperanto.Domain.Enums.Company;
using Esperanto.SharedKernel.Validation;

namespace Esperanto.Domain.Scopes
{
    public static class CompanyScopes
    {
        /// <summary>
        /// Método para realizar as validações no escopo de criação de uma Company
        /// </summary>
        /// <param name="company">Company a ser criada e validada</param>
        /// <returns>Retorna true caso todas as validações sejam satisfeitas</returns>
        public static bool CreateCompanyScopeIsValid(this Company company)
        {
            return AssertionConcern.IsSatisfiedBy
            (

                AssertionConcern.AssertGuidIsNotEmpty(company.CompanyId, "O ID de Company não pode ser vazio"),
                AssertionConcern.AssertNotNull(company, "O Objeto Company a ser criado não pode ser vazio"),
                AssertionConcern.AssertNotEmpty(company.Name, "O Nome da Company não pode ser vazio"),
                AssertionConcern.AssertTrue(company.CompanyStatus == ECompanyStatus.Active || company.CompanyStatus == ECompanyStatus.Inactive, "A Company precisa ter um status válildo")

            );
        }
    }
}
