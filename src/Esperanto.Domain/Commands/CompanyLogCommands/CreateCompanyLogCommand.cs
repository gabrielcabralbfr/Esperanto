using Esperanto.Domain.Enums.Logs;
using System;


namespace Esperanto.Domain.Commands.CompanyLogCommands
{
    public class CreateCompanyLogCommand
    {
        #region Constructor

        /// <summary>
        /// Construtor que recebe atributos do Objeto CompanyLog a ser criado
        /// </summary>
        /// <param name="description">Descrição do Log</param>
        public CreateCompanyLogCommand(string description, ELogType logType)
        {
            this.Description = description;
            this.LogType = logType;
        }

        #endregion


        #region Properties

        /// <summary>
        /// Descrição do log
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Tipo de Log gerado
        /// </summary>
        public ELogType LogType { get; set; }

        #endregion
    }
}
