using Esperanto.Domain.Enums.Logs;
using System;

namespace Esperanto.Domain.Entities
{
    public class UserLog
    {

        #region Constructor

        public UserLog()
        {
           
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

        /// <summary>
        /// FK para entidade do Usuário
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Usuário do log
        /// </summary>
        public User User { get; set; }

        #endregion

    }
}
