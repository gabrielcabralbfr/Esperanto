using Esperanto.Domain.Commands.ProjectIntegrationCommands;
using Esperanto.Domain.Entities;
using System.Collections.Generic;

namespace Esperanto.Domain.Services
{
    public interface IProjectIntegrationAppService
    {
        #region Methods

        /// <summary>
        /// Método para obter todos os projetos
        /// </summary>
        /// <returns>Retorna uma Lista de Integrações do Projeto</returns>
        List<ProjectIntegration> Get();

        /// <summary>
        /// Método para obter uma Lista de Integrações do Projeto ignorando a quantidade informada no parâmetro skip
        /// e selecionando a quantidade informada no parâmetro take
        /// </summary>
        /// <param name="skip">Quantidade de Integrações do Projeto a serem desconsiderados</param>
        /// <param name="take">Quantidade de Integrações do Projeto a serem obtidos</param>
        /// <returns>Retorna uma Lista de Integrações do Projeto</returns>
        List<ProjectIntegration> Get(int skip, int take);

        /// <summary>
        /// Método que recebe um comando de criação de Integrações do Projeto
        /// </summary>
        /// <param name="command">Comando de criação de Integrações do Projeto</param>
        /// <returns>Retorna a Integração do Projeto criado</returns>
        Project Create(CreateProjectIntegrationCommand command);

        #endregion
    }
}
