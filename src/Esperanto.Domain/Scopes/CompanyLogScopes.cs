using Esperanto.Domain.Entities;
using Esperanto.SharedKernel.Validation;

namespace Esperanto.Domain.Scopes
{
    public static class CompanyLogScopes
    {
        /// <summary>
        /// Método para fazer as validações da criação de um Log de Company
        /// </summary>
        /// <param name="companyLog">Log de Company a ser criado</param>
        /// <returns>Retorna true caso as validações sejam satisfeitas</returns>
        public static bool CreateCompanyLogScopeIsValid(this CompanyLog companyLog)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertNotNull(companyLog, "O Log de Company não pode ser vazio"),
                AssertionConcern.AssertNotEmpty(companyLog.Description, "A descrição do log não pode ser nula")
            );
        }
    }
}
