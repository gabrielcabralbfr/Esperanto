using Esperanto.Domain.Entities;
using GTL.WebStore.SharedKernel.Helpers;
using System;
using System.Linq;
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

    }
}
