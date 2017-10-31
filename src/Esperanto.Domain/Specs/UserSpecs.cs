using Esperanto.Domain.Entities;
using Esperanto.Domain.Enums.User;
using Esperanto.SharedKernel.Helpers;
using System;
using System.Linq.Expressions;

namespace Esperanto.Domain.Specs
{
    public static class UserSpecs
    {
        /// <summary>
        /// Método para autenticar o usuário
        /// </summary>
        /// <param name="email">E-mail do usuário</param>
        /// <param name="password">Senha do usuário</param>
        /// <returns>Retorna true caso e-mail e senha estejam corretos</returns>
        public static Expression<Func<User, bool>> AuthenticateUser(string email, string password)
        {
            var encriptedPassword = StringHelper.Encrypt(password);

            return u => u.Email == email && u.Password == encriptedPassword;
        }

        /// <summary>
        /// Método para buscar o usuário pelo ID
        /// </summary>
        /// <param name="id">ID do usuário a ser buscado</param>
        /// <returns>retorna true caso um usuário com o ID informado seja encontrado</returns>
        public static Expression<Func<User, bool>> GetById(Guid id)
        {
            return u => u.UserId == id;
        }

        /// <summary>
        /// Método para buscar o usuário pelo e-mail
        /// </summary>
        /// <param name="email">E-mail do usuário a ser buscado</param>
        /// <returns>retorna true caso um usuário com o e-mail informado seja encontrado</returns>
        public static Expression<Func<User, bool>> GetByEmail(string email)
        {
            return u => u.Email == email;
        }

        /// <summary>
        /// Método para ordenação pelo nome 
        /// </summary>
        /// <returns>Retorna os usuários ordenados pelo nome</returns>
        public static Expression<Func<User, String>> OrderByDefault()
        {
            return u => u.Name;
        }

        /// <summary>
        /// Método para ordenação pela data de criação do usuário
        /// </summary>
        /// <returns>Retorna os usuários ordenados pela data de criação</returns>
        public static Expression<Func<User, DateTime>> OrderByCreationDate()
        {
            return u => u.CreatedOn;
        }


        /// <summary>
        /// Método para obter usuários ativos
        /// </summary>
        /// <returns>retorna usuários ativos</returns>
        public static Expression<Func<User, bool>> GetActives()
        {
            return u => u.UserStatus.Equals(EUserStatus.Active);
        }


        /// <summary>
        /// Método para obter usuários inativos
        /// </summary>
        /// <returns>retorna usuários inativos</returns>
        public static Expression<Func<User, bool>> GetInactives()
        {
            return u => u.UserStatus.Equals(EUserStatus.Inactive);
        }


        /// <summary>
        /// Método para obter usuários com Role = ADMIN
        /// </summary>
        /// <returns>retorna usuários com Role = ADMIN</returns>
        public static Expression<Func<User, bool>> GetAdmins()
        {
            return u => u.UserRole.Equals(EUserRole.Admin);

        }

        /// <summary>
        /// Método para obter usuários com Role = COLLABORATOR
        /// </summary>
        /// <returns>retorna usuários com Role = COLLABORATOR</returns>
        public static Expression<Func<User, bool>> GetCollaborators()
        {
            return u => u.UserRole.Equals(EUserRole.Collaborator);

        }

        /// <summary>
        /// Método para obter usuários com Role = CLIENT
        /// </summary>
        /// <returns>retorna usuários com Role = CLIENT</returns>
        public static Expression<Func<User, bool>> GetClients()
        {
            return u => u.UserRole.Equals(EUserRole.Client);

        }
    }
}
