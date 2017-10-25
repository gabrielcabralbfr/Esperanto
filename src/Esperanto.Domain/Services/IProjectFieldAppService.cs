using Esperanto.Domain.Commands.ProjectFieldCommands;
using Esperanto.Domain.Entities;
using System.Collections.Generic;

namespace Esperanto.Domain.Services
{
    public interface IProjectFieldAppService
    {
        #region Methods

        /// <summary>
        /// Método para obter todos os Campos do Projeto
        /// </summary>
        /// <returns>Retorna uma Lista de Campos do Projeto</returns>
        List<ProjectField> Get();

        /// <summary>
        /// Método para obter uma Lista de Campos do Projeto ignorando a quantidade informada no parâmetro skip
        /// e selecionando a quantidade informada no parâmetro take
        /// </summary>
        /// <param name="skip">Quantidade de Campos do Projeto a serem desconsiderados</param>
        /// <param name="take">Quantidade de Campos do Projeto a serem obtidos</param>
        /// <returns>Retorna uma Lista de Campos do Projeto</returns>
        List<ProjectField> Get(int skip, int take);

        /// <summary>
        /// Método que recebe um comando de criação de Campos do Projeto
        /// </summary>
        /// <param name="command">Comando de criação do Campo do Projeto</param>
        /// <returns>Retorna o Campo do Projeto criado</returns>
        ProjectField Create(CreateProjectFieldCommand command);

        #endregion
    }
}
