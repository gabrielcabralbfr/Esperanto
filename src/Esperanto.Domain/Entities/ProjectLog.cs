using Esperanto.Domain.Enums.ProjectLog;
using System;

namespace Esperanto.Domain.Entities
{
    public class ProjectLog
    {

        #region Properties

        /// <summary>
        /// Project Log ID
        /// </summary>
        public Guid ProjectLogId { get; set; }


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


        /// <summary>
        /// ID do projeto
        /// </summary>
        public Guid ProjectId { get; set; }


        /// <summary>
        /// Projeto referente ao log
        /// </summary>
        public Project Project { get; set; }

        #endregion

    }
}
