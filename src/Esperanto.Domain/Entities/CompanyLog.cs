using System;


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
        public string Description { get; set; }

        /// <summary>
        /// ID da empresa desse log
        /// </summary>
        public Guid CompanyId { get; set; }

        /// <summary>
        /// Empresa desse log
        /// </summary>
        public Company Company { get; set; }
        #endregion
    }
}
