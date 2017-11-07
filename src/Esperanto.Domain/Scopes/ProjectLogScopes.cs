using Esperanto.Domain.Entities;
using Esperanto.SharedKernel.Validation;

namespace Esperanto.Domain.Scopes
{
    public static class ProjectLogScopes
    {
        /// <summary>
        /// Método para fazer as validações da criação de um Log de Project
        /// </summary>
        /// <param name="projectLog">Log de Project a ser criado</param>
        /// <returns>Retorna true caso as validações sejam satisfeitas</returns>
        public static bool CreateProjectLogScopeIsValid(this ProjectLog projectLog)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertNotNull(projectLog, "O Log de Company não pode ser vazio"),
                AssertionConcern.AssertNotEmpty(projectLog.Description, "A descrição do log não pode ser nula"),
                AssertionConcern.AssertGuidIsNotEmpty(projectLog.ProjectLogId, "O ID do log não pode ser vazio")
            );
        }
    }
}
