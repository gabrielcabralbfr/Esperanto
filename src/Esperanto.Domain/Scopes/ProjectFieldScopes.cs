using Esperanto.Domain.Entities;
using Esperanto.SharedKernel.Validation;

namespace Esperanto.Domain.Scopes
{
    public static class ProjectFieldScopes
    {
        /// <summary>
        /// Método para realizar todas as validações na criação de um ProjectField
        /// </summary>
        /// <param name="projectField">ProjectField a ser criado</param>
        /// <returns>Retorna true caso todas as validações sejam satisfeitas</returns>
        public static bool CreateProjectFieldScopeIsValid(this ProjectField projectField)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertNotNull(projectField, "O Objeto não pode ser vazio"),
                AssertionConcern.AssertGuidIsNotEmpty(projectField.ProjectFieldId, "O Guid não pode ser vazio"),
                AssertionConcern.AssertNotEmpty(projectField.Name, "O Nome do campo não pode ser vazio"),
                AssertionConcern.AssertTrue(projectField.OrderPosition >= 0, "A Ordem de processamento deste campo deve ser maior ou igual a 0")
            );
        }

        /// <summary>
        /// Método para realizar todas as validações na atualização de um ProjectField
        /// </summary>
        /// <param name="projectField">ProjectField a ser atualizado</param>
        /// <returns>Retorna true caso todas as validações sejam satisfeitas</returns>
        public static bool UpdateProjectFieldScopeIsValid(this ProjectField projectField)
        {
            return projectField.CreateProjectFieldScopeIsValid();
        }
    }
}
