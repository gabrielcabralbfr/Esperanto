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
        /// Método para obter uma Lista de Users ignorando a quantidade informada no parâmetro skip
        /// e selecionando a quantidade informada no parâmetro take
        /// </summary>
        /// <param name="skip">Quantidade de usuários que serão desconsiderados</param>
        /// <param name="take">Quantidade de usuários que serão considerados</param>
        /// <returns>Retorna List<User> - Quantidade de usuários informada, excluindo quantos usuários foram informados</returns>
        List<User> Get(int skip, int take);


        List<User> Get();

        /// <summary>
        /// Método para buscar os usuários ativos
        /// </summary>
        /// <returns>Retorna List<User> dos usuários com status ativo </returns>
        List<User> GetActives();

        /// <summary>
        /// Método para buscar os usuários inativos
        /// </summary>
        /// <returns>Retorna List<User> dos usuários com status inativo </returns>
        List<User> GetInactives();

        /// <summary>
        /// Método para buscar todos os usuários com ROLE = Admin
        /// </summary>
        /// <returns>Retorna Lista de usuários com Role = Admin</returns>
        List<User> GetAdmins();

        /// <summary>
        /// Método para buscar todos os usuários com ROLE = Collaborator
        /// </summary>
        /// <returns>Retorna Lista de usuários com Role = Collaborator</returns>
        List<User> GetCollaborators();

        /// <summary>
        /// Método para buscar todos os usuários com ROLE = Client
        /// </summary>
        /// <returns>Retorna Lista de usuários com Role = Client</returns>
        List<User> GetClients();


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
        User Delete(Guid UserId);

        /// <summary>
        /// Método para atualizar um usuário
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        User Update(UpdateUserCommand command);

        /// <summary>
        /// Método para tornar um usuário ativo
        /// </summary>
        /// <param name="user">Usuário a ser ativado</param>
        /// <returns>Retorna true caso o usuário tenha sido ativado</returns>
        bool ActivateUser(User user);


        /// <summary>
        /// Método para tornar um usuário inativo
        /// </summary>
        /// <param name="user">Usuário a ser desativado</param>
        /// <returns>Retorna true caso o usuário tenha sido desativado</returns>
        bool DeactivateUser(User user);

        #endregion

    }
}
