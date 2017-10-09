using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esperanto.Domain.Entities
{
    public class CompanyLog
    {
        #region Properties

        /// <summary>
        /// CompanyLog ID
        /// </summary>
        public Guid CompanyLogId{ get; set; }

        /// <summary>
        /// Data de criação do Log
        /// </summary>
        public DateTime CreatedOn{ get; set; }

        /// <summary>
        /// Descrição do log
        /// </summary>
        public string Description { get; set; }]

        /// <summary>
        /// ID da empresa
        /// </summary>
        public Guid CompanyId { get; set; }

        /// <summary>
        /// Empresa
        /// </summary>
        public Company Company { get; set; }
        #endregion
    }
}
