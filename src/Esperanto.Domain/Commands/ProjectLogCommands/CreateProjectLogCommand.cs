using Esperanto.Domain.Enums.Logs;
using System;


namespace Esperanto.Domain.Commands.ProjectLogCommands
{
    public class CreateProjectLogCommand
    {

        #region Constructor

        /// <summary>
        /// Construtor que recebe atributos do Objeto ProjectLog a ser criado
        /// </summary>
        /// <param name="description">Descrição do Log</param>
        /// <param name="logType">Descrição do tipo do log a ser criado</param>
        public CreateProjectLogCommand(string description, ELogType logType)
        {
            this.Description = description;
            this.CreatedOn = DateTime.Now;
            this.LogType = logType;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Data de criação do log
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Descrição do log
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Tipo de log gerado
        /// </summary>
        public ELogType LogType { get; set; }

        #endregion
    }
}
