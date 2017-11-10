using Esperanto.Domain.Entities;
using Esperanto.SharedKernel.Validation;

namespace Esperanto.Domain.Scopes
{
    public static class ProjectIntegrationScopes
    {
        /// <summary>
        /// Método para realizar todas as validações na criação de uma integração
        /// </summary>
        /// <param name="projectIntegration">Entidade para Integração do projeto</param>
        /// <returns>Retorna true caso todas as validações sejam satisfeitas</returns>
        public static bool CreateProjectIntegrationScopeIsValid(this ProjectIntegration projectIntegration)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertGuidIsNotEmpty(projectIntegration.ProjectIntegrationId, "O ID do ProjectIntegration não pode ser vazio"),
                AssertionConcern.AssertLength(projectIntegration.Username, 3, 50, "O Username precisa ter no mínimo 3 caracteres e no máximo 50"),
                AssertionConcern.AssertNotEmpty(projectIntegration.Username, "O Nome de usuário da integração não pode ser vazio"),
                AssertionConcern.AssertLength(projectIntegration.ServerPath, 5, 140, "O caminho do servidor precisa ter no mínimo 5 caracteres e no máximo 140"),
                AssertionConcern.AssertNotEmpty(projectIntegration.ServerPath, "O caminho do servidor da integração não pode ser vazio"),
                AssertionConcern.AssertLength(projectIntegration.Password, 3, 32, "A senha precisa ter no mínimo 3 caracteres e no máximo 32"),
                AssertionConcern.AssertNotEmpty(projectIntegration.Password, "A senha da integração não pode ser vazio"),
                AssertionConcern.AssertIsGreaterThan(projectIntegration.MigrationInterval, 1, "O intervalo de migração precisa ser maior que 0."),
                AssertionConcern.AssertTrue(projectIntegration.DeleteFile == true || projectIntegration.DeleteFile == false, "Um valor booleano precisa ser especificado para o campo DeleteFile")
            );
        }

        /// <summary>
        /// Método para realizar todas as validações na atualização de uma integração
        /// </summary>
        /// <param name="projectIntegration">Integração a ser atualizada</param>
        /// <returns>Retorna true caso todas as validações sejam satisfeitas</returns>
        public static bool UpdateProjectIntegrationScopeIsValid(this ProjectIntegration projectIntegration)
        {
            return projectIntegration.CreateProjectIntegrationScopeIsValid();
        }
    }
}
