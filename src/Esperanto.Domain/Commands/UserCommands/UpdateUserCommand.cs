using System;
using Esperanto.Domain.Enums.User;


namespace Esperanto.Domain.Commands.UserCommands
{
    public class UpdateUserCommand
    {
        #region Constructor

        /// <summary>
        /// Construtor que recebe os atributos do Objeto User a ser atualizado
        /// </summary>
        /// <param name="email">E-mail do usuário</param>
        /// <param name="password">Senha do usuário</param>
        /// <param name="name">Nome do usuário</param>
        /// <param name="userRole">Perfil do usuário</param>
        public UpdateUserCommand(string email, string password, string name, EUserRole userRole)
        {
            this.Email = email;
            this.Password = password;
            this.Name = name;
            this.UserRole = userRole;
            this.CreatedOn = DateTime.Now;
            this.UserStatus = EUserStatus.Active;

        }
        #endregion



        #region Properties
        /// <summary>
        /// Nome do usuário
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// E-mail do usuário
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Senha do usuário
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Data de criação do usuário
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Data de modificação do usuário
        /// </summary>
        public DateTime ModifiedOn { get; set; }

        /// <summary>
        /// Status do usuário
        /// </summary>
        public EUserStatus UserStatus { get; set; }

        /// <summary>
        /// Perfil do usuário
        /// </summary>
        public EUserRole UserRole { get; set; }
        #endregion
    }
}
