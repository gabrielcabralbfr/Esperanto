using Esperanto.Domain.Commands.UserCommands;
using Esperanto.Domain.Enums.User;
using Esperanto.Domain.Scopes;
using System;
using System.Collections.Generic;

namespace Esperanto.Domain.Entities
{
    /// <summary>
    /// Entidade para o Usuário do sistema
    /// </summary>
    public class User
    {
        #region Constructor

        /// <summary>
        /// Construtor padrão
        /// </summary>
        protected User() { }


        /// <summary>
        /// Método construtor da Entidade Usuário
        /// </summary>
        /// <param name="command">Comando de criação do usuário</param>
        public User(CreateUserCommand command)
        {
            UserId = Guid.NewGuid();
            this.Name = command.Name;
            this.Email = command.Email;
            this.Password = command.Password;
            CreatedOn = DateTime.Now;
            this.UserStatus = EUserStatus.Active;
            UserRole = command.UserRole;

        }
        #endregion

        #region Properties

        /// <summary>
        /// ID do usuário
        /// </summary>
        public Guid UserId { get; private set; }

        /// <summary>
        /// Nome do usuário
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// E-mail do usuário
        /// </summary>
        public string Email { get; private set; }

        /// <summary>
        /// Senha do usuário
        /// </summary>
        public string Password { get; private set; }

        /// <summary>
        /// Data de criação do usuário
        /// </summary>
        public DateTime CreatedOn { get; private set; }

        /// <summary>
        /// Data de modificação do usuário
        /// </summary>
        public DateTime ModifiedOn { get; private set; }

        /// <summary>
        /// Status do usuário
        /// </summary>
        public EUserStatus UserStatus { get; private set; }

        /// <summary>
        /// Perfil do usuário
        /// </summary>
        public EUserRole UserRole { get; private set; }

        /// <summary>
        /// Key para API
        /// </summary>
        public Guid ApiKey { get; private set; }

        /// <summary>
        /// UserLog ID
        /// </summary>
        public Guid UserLogId { get; private set; }

        /// <summary>
        /// UserLogs
        /// </summary>
        public List<UserLog> UserLogs { get; private set; }
        #endregion

        #region Methods

        /// <summary>
        /// Método para autenticar o usuário
        /// </summary>
        /// <param name="email">E-email a ser autenticado</param>
        /// <param name="password">Senha do usuário a ser autenticado</param>
        /// <returns>Retorna true caso o usuário seja autenticado</returns>
        public bool AuthenticateUser(string email, string password)
        {
            if (this.AuthenticateUserScopeIsValid(email, password))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Método para Criação do usuário
        /// </summary>
        /// <param name="user">Usuário a ser criado</param>
        /// <returns>Retorna true caso o escopo de criação do usuário seja válido</returns>
        public bool CreateUser(User user)
        {
            if (this.CreateUserScopeIsValid())
            {
                return true;
            }

            return false;
        }

        /// <summary>
        ///  Método para tornar um Usuário ativo
        /// </summary>
        public void ActivateUser()
        {
            this.UserStatus = EUserStatus.Active;
        }


        /// <summary>
        ///  Método para tornar um Usuário inativo
        /// </summary>
        public void DeactivateUser()
        {
            this.UserStatus = EUserStatus.Inactive;
        }

        /// <summary>
        /// Método para realizar a troca de senha do usuário
        /// </summary>
        /// <param name="newPassword">Nova senha</param>
        /// <returns>Retorna true caso as validações de troca de senha sejam satisfeitas</returns>
        public bool ChangePassword(string newPassword)
        {
            if (this.ChangeUserPasswordIsValid(newPassword))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Método para obter todos os Lgos de Usuário
        /// </summary>
        /// <returns>Retorna uma Lista de Logs pertencente à um Usuário</returns>
        public List<UserLog> GetLogs()
        {
            return this.UserLogs;
        }
        #endregion

    }
}
