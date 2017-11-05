using Esperanto.Domain.Entities;
using Esperanto.SharedKernel.Validation;

namespace Esperanto.Domain.Scopes
{
    public static class ProjectScopes
    {
        public static bool CreateProjectScopeIsValid(this Project project)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertGuidIsNotEmpty(project.ProjectId, "O ID do projeto não pode ser nulo"),
                AssertionConcern.AssertGuidIsNotEmpty(project.LicenseId, "O License ID do projeto não pode ser nulo"),
                AssertionConcern.AssertGuidIsNotEmpty(project.PermissionId, "O Permission ID do projeto não pode ser nulo"),
                AssertionConcern.AssertLength(project.FileName, 1, 100, "O nome do arquivo deve ter no mínimo 1 e no máximo 100 caracteres"),
                AssertionConcern.AssertEmailIsValid(project.ErrorEmail, "O e-mail informado é inválido")
            );
        }
    }
}
