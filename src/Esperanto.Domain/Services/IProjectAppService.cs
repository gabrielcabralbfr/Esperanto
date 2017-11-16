using Esperanto.Domain.Commands.ProjectCommands;
using Esperanto.Domain.Entities;
using Esperanto.Domain.Enums.Project;
using System.Collections.Generic;

namespace Esperanto.Domain.Services
{
    public interface IProjectAppService
    {
        #region Methods

        /// <summary>
        /// Método para obter todos os projetos
        /// </summary>
        /// <returns>Retorna uma Lista de Projetos</returns>
        List<Project> Get();

        /// <summary>
        /// Método para obter uma Lista de Projetos ignorando a quantidade informada no parâmetro skip
        /// e selecionando a quantidade informada no parâmetro take
        /// </summary>
        /// <param name="skip">Quantidade de Projetos a serem desconsiderados</param>
        /// <param name="take">Quantidade de Projetos a serem obtidos</param>
        /// <returns>Retorna uma Lista de Projetos</returns>
        List<Project> Get(int skip, int take);

        /// <summary>
        /// Método que recebe um comando de criação de Projeto
        /// </summary>
        /// <param name="command">Comando de criação do Projeto</param>
        /// <returns>Retorna o Project criado</returns>
        Project Create(CreateProjectCommand command);

        /// <summary>
        /// Método que recebe um comando de atualização de um Project
        /// </summary>
        /// <param name="command">Comando de atualização de um Project</param>
        /// <returns>Retorna o Projeto atualizado</returns>
        Project Update(UpdateProjectCommand command);

        /// <summary>
        /// Método que recebe um comando de exclusão de um Project
        /// </summary>
        /// <param name="command">Comando de exclusão do Projeto</param>
        void Delete(DeleteProjectCommand command);

        /// <summary>
        /// Método para tornar um projeto ativo
        /// </summary>
        bool Activate(Project project);

        /// <summary>
        /// Método para tornar um projeto inativo
        /// </summary>
        bool Dectivate(Project project);

        /// <summary>
        /// Método para alterar o tipo de envio do Projeto
        /// </summary>
        /// <param name="newType">Novo tipo de envio</param>
        void ChangeSendType(Project project, ESendType newType);

        /// <summary>
        /// Método para alterar o tipo de arquivo do Projeto
        /// </summary>
        /// <param name="newType">Novo tipo de arquivo</param>
        void ChangeFileType(Project project, EFileType newType);

        #endregion
    }
}
