using Esperanto.Domain.Commands.UserLogCommands;
using Esperanto.Domain.Entities;
using System.Collections.Generic;


namespace Esperanto.Domain.Services
{
    public interface IUserLogAppService
    {
        #region Methods

        /// <summary>
        /// Método para obter todos os Logs do Usuário
        /// </summary>
        /// <returns>Retorna uma lista de UserLog</returns>
        List<UserLog> Get();

        /// <summary>
        /// Método para obter uma Lista de UserLog ignorando a quantidade informada no parâmetro skip
        /// e selecionando a quantidade informada no parâmetro take
        /// </summary>
        /// <param name="skip">Quantidade de UserLog a serem desconsiderados</param>
        /// <param name="take">Quantidade de UserLog a serem obtidos</param>
        /// <returns>Retorna uma Lista de UserLog</returns>
        List<Company> Get(int skip, int take);

        /// <summary>
        /// Método para criação do Log do Usuário
        /// </summary>
        /// <param name="command">Comando de criação do Log do Usuário</param>
        /// <returns>Retorna o Log do Usuário que foi criado</returns>
        UserLog Create(CreateUserLogCommand command);

        #endregion
    }
}
