using Esperanto.Domain.Enums.Logs;
using System;


namespace Esperanto.Domain.Commands.UserLogCommands
{
    public class CreateUserLogCommand
    {
        #region Constructor

        /// <summary>
        /// Construtor que recebe os atributos do Objeto UserLog a ser criado
        /// </summary>
        /// <param name="userLogId">ID do UserLog</param>
        /// <param name="description">Descrção do Log</param>
        public CreateUserLogCommand(Guid userLogId, string description)
        {
            this.UserLogId = userLogId;
            this.CreatedOn = DateTime.Now;
            this.Description = description;
        }

        #endregion


        #region Properties

        /// <summary>
        /// ID do log do usuário
        /// </summary>
        public Guid UserLogId { get; set; }

        /// <summary>
        /// Data de criaçao do Log do Usuário
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Descrição do Log do usuário
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Tipo de log gerado
        /// </summary>
        public ELogType LogType { get; set; }

        #endregion
    }
}
