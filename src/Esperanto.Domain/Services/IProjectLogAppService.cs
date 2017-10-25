using Esperanto.Domain.Commands.ProjectLogCommands;
using Esperanto.Domain.Entities;
using System.Collections.Generic;


namespace Esperanto.Domain.Services
{
    public interface IProjectLogLogAppService
    {

        #region Methods

        /// <summary>
        /// Método para obter todos os Log de Projetos
        /// </summary>
        /// <returns>Retorna uma Lista de Log de Projetos</returns>
        List<ProjectLog> Get();

        /// <summary>
        /// Método para obter uma Lista de Log de Projetos ignorando a quantidade informada no parâmetro skip
        /// e selecionando a quantidade informada no parâmetro take
        /// </summary>
        /// <param name="skip">Quantidade de Log de Projetos a serem desconsiderados</param>
        /// <param name="take">Quantidade de Log de Projetos a serem obtidos</param>
        /// <returns>Retorna uma Lista de Log de Projetos</returns>
        List<ProjectLog> Get(int skip, int take);

        /// <summary>
        /// Método que recebe um comando de criação de Log de Projetos
        /// </summary>
        /// <param name="command">Comando de criação do Log de Projetos</param>
        /// <returns>Retorna o ProjectLog criado</returns>
        ProjectLog Create(CreateProjectLogCommand command);

        #endregion

    }
}
