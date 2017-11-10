using Esperanto.Domain.Commands.UserLogCommands;
using Esperanto.Domain.Enums.Logs;
using Esperanto.Domain.Scopes;
using System;

namespace Esperanto.Domain.Entities
{
    /// <summary>
    /// Entidade que representa os Logs do Usuário
    /// </summary>
    public class UserLog
    {

        #region Constructor
        
        /// <summary>
        /// Construtor padrão
        /// </summary>
        protected UserLog() { }

        /// <summary>
        /// Construtor da entidade UserLog
        /// </summary>
        /// <param name="command">comando de criação do Log do Usuário</param>
        public UserLog(CreateUserLogCommand command)
        {
            this.UserLogId = Guid.NewGuid();
            this.Description = command.Description;
            this.LogType = command.LogType;
            this.CreatedOn = DateTime.Now;
        }

        #endregion


        #region Properties

        /// <summary>
        /// ID do log do usuário
        /// </summary>
        public Guid UserLogId { get; private set; }

        /// <summary>
        /// Data de criaçao do Log do Usuário
        /// </summary>
        public DateTime CreatedOn { get; private set; }

        /// <summary>
        /// Descrição do Log do usuário
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Tipo de log gerado
        /// </summary>
        public ELogType LogType { get; private set; }

        /// <summary>
        /// FK para entidade do Usuário
        /// </summary>
        public Guid UserId { get; private set; }

        /// <summary>
        /// Usuário do log
        /// </summary>
        public User User { get; private set; }

        #endregion


        #region Methods

        /// <summary>
        /// Método de Criação de um Log de Usuário
        /// </summary>
        /// <param name="userLog">Log a ser criado</param>
        /// <returns>Retorna true caso as validações sejam satisfeitas</returns>
        public bool CreateUserlog(UserLog userLog)
        {
            if (this.CreateUserLogScopeIsValid())
            {
                return true;
            }

            return false;
        }

        #endregion

    }
}
