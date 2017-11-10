using Esperanto.Domain.Enums.Company;
using System;


namespace Esperanto.Domain.Commands.CompanyCommands
{
    public class CreateCompanyCommand
    {

        #region Constructor

        /// <summary>
        /// Construtor que recebe atributos do Objeto Company a ser criado
        /// </summary>
        /// <param name="name">Nome da Company</param>
        public CreateCompanyCommand(string name)
        {
            this.Name = name;
            this.CreatedOn = DateTime.Now;
            this.CompanyStatus = ECompanyStatus.Active;
        }
        #endregion


        #region Properties

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
