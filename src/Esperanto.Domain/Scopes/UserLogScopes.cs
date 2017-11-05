using Esperanto.Domain.Entities;
using Esperanto.SharedKernel.Validation;

namespace Esperanto.Domain.Scopes
{
    public static class UserLogScopes
    {
        /// <summary>
        /// Método para fazer as validações da criação de um Log de Usuário
        /// </summary>
        /// <param name="userLog">Log de Usuário a ser criado</param>
        /// <returns>Retorna true caso as validações sejam satisfeitas</returns>
        public static bool CreateUserLogScopeIsValid(this UserLog userLog)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertNotNull(userLog, "O Log de usuário não pode ser vazio"),
                AssertionConcern.AssertNotEmpty(userLog.Description, "A descrição do log não pode ser nula")
            );  
        }
    }
}
