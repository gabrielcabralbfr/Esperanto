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
                AssertionConcern.AssertNotEmpty(projectField.Name, "O Nome do campo não pode ser vazio")
            );
        }
    }
}
