using Esperanto.Domain.Entities;
using Esperanto.SharedKernel.Validation;

namespace Esperanto.Domain.Scopes
{
    public static class ProjectIntegrationScopes
    {
        /// <summary>
        /// Método para realizar todas as validações na criação de uma integração
        /// </summary>
        /// <param name="projectIntegration"></param>
        /// <returns></returns>
        public static bool CreateProjectIntegrationScopeIsValid(this ProjectIntegration projectIntegration)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertGuidIsNotEmpty(projectIntegration.ProjectIntegrationId, "O ID do ProjectIntegration não pode ser vazio"),
                AssertionConcern.AssertLength(projectIntegration.Username, 3, 50, "O Username precisa ter no mínimo 3 caracteres e no máximo 50"),
                AssertionConcern.AssertLength(projectIntegration.ServerPath, 5, 140, "O caminho do servidor precisa ter no mínimo 5 caracteres e no máximo 140"),
                AssertionConcern.AssertLength(projectIntegration.Password, 3, 32, "A senha precisa ter no mínimo 3 caracteres e no máximo 32"),
                AssertionConcern.AssertIsGreaterOrEqualThan(projectIntegration.MigrationInterval, 0, "O intervalo de migração precisa ser maior ou igual a 1.")
            );
        }
    }
}
