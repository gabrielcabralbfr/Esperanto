using Esperanto.Domain.Commands.ProjectLogCommands;
using Esperanto.Domain.Enums.Logs;
using Esperanto.Domain.Scopes;
using System;

namespace Esperanto.Domain.Entities
{
    /// <summary>
    /// Entidade que representa os Logs do Projeto
    /// </summary>
    public class ProjectLog
    {
        #region Constructor

        /// <summary>
        /// Construtor padrão
        /// </summary>
        public ProjectLog() { }

        /// <summary>
        /// Método construtor da Entidade que recebe um comando para criação de um Log de Projeto
        /// </summary>
        /// <param name="command">Comando de criação do Log</param>
        public ProjectLog(CreateProjectLogCommand command)
        {
            ProjectLogId = command.ProjectLogId;
            CreatedOn = command.CreatedOn;
            Description = command.Description;
            LogType = command.LogType;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Project Log ID
        /// </summary>
        public Guid ProjectLogId { get; private set; }


        /// <summary>
        /// Data de criação do log
        /// </summary>
        public DateTime CreatedOn { get; private set; }

        /// <summary>
        /// Descrição do log
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Tipo de log gerado
        /// </summary>
        public ELogType LogType { get; private set; }


        /// <summary>
        /// ID do projeto
        /// </summary>
        public Guid ProjectId { get; private set; }


        /// <summary>
        /// Projeto referente ao log
        /// </summary>
        public Project Project { get; private set; }

        #endregion

        #region Methods

        /// <summary>
        /// Método para criação do Log do Projeto
        /// </summary>
        /// <param name="projectLog">Log a ser criado</param>
        /// <returns>Retorna true caso o escopo de criação seja válido</returns>
        public bool CreateProjectLog(ProjectLog projectLog)
        {
            if (this.CreateProjectLogScopeIsValid())
            {
                return true;
            }

            return false;
        }

        #endregion
    }
}
