using Esperanto.Domain.Enums.Logs;
using System;


namespace Esperanto.Domain.Commands.UserLogCommands
{
    /// <summary>
    /// Comando de criação de um Log de usuário
    /// </summary>
    public class CreateUserLogCommand
    {
        #region Constructor

        /// <summary>
        /// Construtor que recebe os atributos do Objeto UserLog a ser criado
        /// </summary>
        /// <param name="description">Descrção do Log</param>
        public CreateUserLogCommand(Guid userLogId, string description, ELogType logType)
        {
            this.Description = description;
            this.LogType = logType;
        }

        #endregion


        #region Properties
        
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
