using Esperanto.Domain.Entities;
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

    }
}
