using System;


namespace Esperanto.Domain.Commands.CompanyLogCommands
{
    public class CreateCompanyLogCommand
    {
        #region Constructor

        /// <summary>
        /// Construtor que recebe atributos do Objeto CompanyLog a ser criado
        /// </summary>
        /// <param name="companyLogId">CompanyLog ID</param>
        /// <param name="description">Descrição do Log</param>
        public CreateCompanyLogCommand(Guid companyLogId, string description)
        {
            this.CompanyLogId = companyLogId;
            this.Description = description;
            this.CreatedOn = DateTime.Now;
        }

        #endregion


        #region Properties

        /// <summary>
        /// CompanyLog ID
        /// </summary>
        public Guid CompanyLogId { get; set; }

        /// <summary>
        /// Data de criação do Log
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Descrição do log
        /// </summary>
        public string Description { get; set; }

        #endregion
    }
}
