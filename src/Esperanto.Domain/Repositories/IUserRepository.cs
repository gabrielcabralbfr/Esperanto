using Esperanto.Domain.Entities;
using System;
using System.Collections.Generic;


namespace Esperanto.Domain.Repositories
{
    public interface IUserRepository
    {
        /// <summary>
        /// Método para trazer todos os usuários
        /// </summary>
        /// <returns>Retorna todos os usuários</returns>
        List<User> Get();


        /// <summary>
        /// Método para trazer os usuários
        /// </summary>
        /// <param name="skip">Quantidade de usuários que serão desconsiderados</param>
        /// <param name="take">Quantidade de usuários que serão considerados</param>
        /// <returns>Retorna a quantidade de usuários informada, excluindo quantos usuários foram informados</returns>
        List<User> Get(int skip, int take);

        /// <summary>
        /// Método para buscar usuário pelo ID
        /// </summary>
        /// <param name="userID">ID do usuário a ser buscado</param>
        /// <returns>Retorna o usuário que possui o ID informado</returns>
        User GetById(Guid userID);

        /// <summary>
        /// Método para criar o usuário
        /// </summary>
        /// <param name="user">Usuário a ser criado</param>
        void Create(User user);

        /// <summary>
        /// Método para atualizar um usuário
        /// </summary>
        /// <param name="user">Usuário a ser atualizado</param>
        void Update(User user);

        /// <summary>
        /// Método para remover o usuário
        /// </summary>
        /// <param name="user">Usuário a ser removido</param>
        void Delete(User user);

        /// <summary>
        /// Método para autenticação do usuário através de email e senha.
        /// </summary>
        /// <param name="email">E-mail do usuário a ser autenticado</param>
        /// <param name="password">Senha do usuário a ser autenticado</param>
        /// <returns>Retorna o usuário autenticado</returns>
        User Authenticate(string email, string password);
    }
}
