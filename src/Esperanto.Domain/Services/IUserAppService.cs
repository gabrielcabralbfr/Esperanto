using Esperanto.Domain.Commands.UserCommands;
using Esperanto.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Esperanto.Domain.Services
{
    public interface IUserAppService
    {

        #region Methods
        
        /// <summary>
        /// Método para obter todos os usuários
        /// </summary>
        /// <returns>Retorna uma lista de Usuários</returns>
        List<User> Get();

        /// <summary>
        /// Método para autenticar o usuário através de e-mail e senha
        /// </summary>
        /// <param name="command">Comando de autenticação do usuário contendo os atributos</param>
        /// <returns>Retorna o usuário autenticado</returns>
        User Authenticate(AuthenticateUserCommand command);

        /// <summary>
        /// Método para fazer o serviço de criar um usuário
        /// </summary>
        /// <param name="command">Comando de criação do usuário contendo os atributos</param>
        /// <returns>Retorna o usuário criado</returns>
        User Create(CreateUserCommand command);

        /// <summary>
        /// Método para deletar um usuário
        /// </summary>
        /// <param name="command">Comando de exclusão do usuário contendo todos os atributos</param>
        void Delete(DeleteUserCommand command);

        /// <summary>
        /// Método para atualizar um usuário
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        User Update(UpdateUserCommand command);


        #endregion

    }
}
