using Esperanto.Domain.Commands.CompanyLogCommands;
using Esperanto.Domain.Enums.Logs;
using Esperanto.Domain.Scopes;
using System;


namespace Esperanto.Domain.Entities
{
    /// <summary>
    /// Entidade para os Logs gerados por uma entidade do tipo Company
    /// </summary>
    public class CompanyLog
    {
        #region Constructor

        /// <summary>
        /// Construtor padrão
        /// </summary>
        protected CompanyLog() { }

        /// <summary>
        /// Método construtor da entidade CompanyLog que recebe o command de criação
        /// </summary>
        /// <param name="command">Comando de criação do Log</param>
        public CompanyLog(CreateCompanyLogCommand command)
        {
            this.CompanyLogId = Guid.NewGuid();
            this.CreatedOn = DateTime.Now;
            this.Description = command.Description;
            this.LogType = command.LogType;
        }

        #endregion

        #region Properties

        /// <summary>
        /// CompanyLog ID
        /// </summary>
        public Guid CompanyLogId { get; private set; }

        /// <summary>
        /// Data de criação do Log
        /// </summary>
        public DateTime CreatedOn { get; private set; }

        /// <summary>
        /// Descrição do log
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Tipo de Log gerado
        /// </summary>
        public ELogType LogType { get; private set; }

        /// <summary>
        /// ID da empresa desse log
        /// </summary>
        public Guid CompanyId { get; private set; }

        /// <summary>
        /// Empresa desse log
        /// </summary>
        public Company Company { get; private set; }
        #endregion

        #region Methods

        /// <summary>
        /// Método para criação do Log de uma Company
        /// </summary>
        /// <param name="companyLog">Log a ser criado</param>
        /// <returns>Retorna true caso a validação seja satisfeita e o Log possa ser criado</returns>
        public bool CreateCompanyLog(CompanyLog companyLog)
        {
            if (companyLog.CreateCompanyLogScopeIsValid())
            {
                return true;
            }

            return false;
        }

        #endregion
    }
}
