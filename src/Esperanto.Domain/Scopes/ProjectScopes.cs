using Esperanto.Domain.Entities;
using Esperanto.SharedKernel.Validation;

namespace Esperanto.Domain.Scopes
{
    public static class ProjectScopes
    {
        /// <summary>
        /// Método para verificar se o escopo de criação de um Projeto é valido
        /// </summary>
        /// <param name="project">Projeto a ser criado</param>
        /// <returns>Retorna true caso todas as validações sejam satisfeitas</returns>
        public static bool CreateProjectScopeIsValid(this Project project)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertGuidIsNotEmpty(project.ProjectId, "O ID do projeto não pode ser nulo"),
                AssertionConcern.AssertNotEmpty(project.Name, "O Nome do Projeto não pode ser vazio"),
                AssertionConcern.AssertGuidIsNotEmpty(project.LicenseId, "O License ID do projeto não pode ser nulo"),
                AssertionConcern.AssertGuidIsNotEmpty(project.PermissionId, "O Permission ID do projeto não pode ser nulo"),
                AssertionConcern.AssertNotEmpty(project.FileType.ToString(), "O tipo de arquivo não pode ser vazio"),
                AssertionConcern.AssertNotEmpty(project.DivisorChar.ToString(), "É necessário especificar um caracter divisor para o Projeto"),
                AssertionConcern.AssertLength(project.FileName, 1, 100, "O nome do arquivo deve ter no mínimo 1 e no máximo 100 caracteres"),
                AssertionConcern.AssertNotEmpty(project.FileName, "O nome do arquivo não pode ser vazio"),
                AssertionConcern.AssertEmailIsValid(project.ErrorEmail, "O e-mail informado é inválido"),
                AssertionConcern.AssertNotEmpty(project.ErrorEmail, "O e-mail não pode ser vazio"),
                AssertionConcern.AssertTrue(project.IgnoreFirstLine == true || project.IgnoreFirstLine == false, "Você precisa especificar um valor booleano para o campo IgnoreFirstLine"),
                AssertionConcern.AssertNotEmpty(project.ProjectStatus.ToString(), "O status do Projeto não pode ser vazio")
            );
        }

        /// <summary>
        /// Método para validar o escopo de atualização do Projeto
        /// </summary>
        /// <param name="project">Projeto a ser atualizado</param>
        /// <returns>Retorna true caso todas as validações sejam satisfeitas</returns>
        public static bool UpdateProjectScopeIsValid(Project project)
        {
            return project.CreateProjectScopeIsValid();

        }
    }
}
