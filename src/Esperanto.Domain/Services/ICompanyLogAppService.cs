using Esperanto.Domain.Commands.CompanyLogCommands;
using Esperanto.Domain.Entities;
using System.Collections.Generic;

namespace Esperanto.Domain.Services
{
    public interface ICompanyLogAppService
    {
        #region Methods

        /// <summary>
        /// Método para obter todos Logs de Company
        /// </summary>
        /// <returns>Retorna uma Lista de Logs de Company</returns>
        List<CompanyLog> Get();

        /// <summary>
        /// Método para obter uma Lista de Logs de Company ignorando a quantidade informada no parâmetro skip
        /// e selecionando a quantidade informada no parâmetro take
        /// </summary>
        /// <param name="skip">Quantidade de Logs de Company a serem desconsiderados</param>
        /// <param name="take">Quantidade de Logs de Company a serem obtidos</param>
        /// <returns>Retorna uma Lista de Logs de Company</returns>
        List<CompanyLog> Get(int skip, int take);

        /// <summary>
        /// Método que recebe um comando de criação de Log de Company
        /// </summary>
        /// <param name="command">Comando de criação do Log de Company</param>
        /// <returns>Retorna a Logs de Company criada</returns>
        CompanyLog Create(CreateCompanyLogCommand command);

        #endregion
    }
}
