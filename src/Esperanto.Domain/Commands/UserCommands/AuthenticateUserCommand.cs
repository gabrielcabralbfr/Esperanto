using System;


namespace Esperanto.Domain.Commands.UserCommands
{
    public class AuthenticateUserCommand
    {
        #region Constructor

        /// <summary>
        /// Método para autenticar o usuário que recebe todos os atributos do Objeto Usuário
        /// </summary>
        /// <param name="userId">ID do usuário</param>
        /// <param name="email">E-mail do usuário a ser autenticado</param>
        /// <param name="password">Senha do usuário a ser autenticado</param>
        public AuthenticateUserCommand(Guid userId, string email, string password)
        {
            this.UserId = userId;
            this.Email = email;
            this.Password = password;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Id do usuário
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// E-mail do usuário
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Senha do usuário
        /// </summary>
        public string Password { get; set; }

        #endregion
    }
}
