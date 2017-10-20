using Esperanto.Domain.Enums.Company;
using System;


namespace Esperanto.Domain.Commands.CompanyCommands
{
    public class UpdateCompanyCommand
    {

        #region Constructor

        /// <summary>
        /// Construtor que recebe atributos do Objeto Company a ser atualizada
        /// </summary>
        /// <param name="companyId">ID</param>
        /// <param name="name">Nome da Company</param>
        public UpdateCompanyCommand(Guid companyId, string name)
        {
            this.CompanyId = companyId;
            this.Name = name;
            this.ModifiedOn = DateTime.Now;
        }
        #endregion


        #region Properties
        /// <summary>
        /// Company ID
        /// </summary>
        public Guid CompanyId { get; set; }

        /// <summary>
        /// Nome da empresa
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Data de criação da empresa no sistema
        /// </summary>
        public DateTime CreatedOn { get; set; }


        /// <summary>
        /// Data de modificação da empresa no sistema
        /// </summary>
        public DateTime ModifiedOn { get; set; }


        /// <summary>
        /// Status da empresa
        /// </summary>
        public ECompanyStatus CompanyStatus { get; set; }


        #endregion
    }
}
