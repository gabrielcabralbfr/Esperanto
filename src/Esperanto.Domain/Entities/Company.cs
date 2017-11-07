using Esperanto.Domain.Commands.CompanyCommands;
using Esperanto.Domain.Enums.Company;
using System;
using System.Collections.Generic;

namespace Esperanto.Domain.Entities
{
    public class Company
    {

        #region Constructor

        /// <summary>
        /// Construtor padrão
        /// </summary>
        protected Company() {   }

        /// <summary>
        /// Construtor da classe Company
        /// </summary>
        /// <param name="command">Comando de criação de uma Company</param>
        public Company(CreateCompanyCommand command)
        {
            this.CompanyId = command.CompanyId;
            this.Name = command.Name;
            this.CreatedOn = command.CreatedOn;
            this.ModifiedOn = command.ModifiedOn;
            this.CompanyStatus = command.CompanyStatus;
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

        /// <summary>
        /// Company Log ID
        /// </summary>
        public Guid CompanyLogId { get; set; }

        /// <summary>
        /// CompanyLog
        /// </summary>
        public List<CompanyLog> CompanyLogs { get; set; }

        /// <summary>
        /// Project  ID
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// Projects
        /// </summary>
        public List<Project> Projects { get; set; }


        #endregion


        #region Methods

        /// <summary>
        /// Método para tornar uma Company ativa
        /// </summary>
        public void ActivateCommpany()
        {
            this.CompanyStatus = ECompanyStatus.Active;
        }


        /// <summary>
        /// Método para tornar uma Company inativa
        /// </summary>
        public void Deactivate()
        {
            this.CompanyStatus = ECompanyStatus.Inactive;
        }

        #endregion

    }
}
