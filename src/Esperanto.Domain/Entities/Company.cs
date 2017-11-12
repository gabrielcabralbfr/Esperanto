using Esperanto.Domain.Commands.CompanyCommands;
using Esperanto.Domain.Enums.Company;
using Esperanto.Domain.Scopes;
using System;
using System.Collections.Generic;

namespace Esperanto.Domain.Entities
{
    /// <summary>
    /// Entidade Company
    /// </summary>
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
            this.CompanyId = Guid.NewGuid();
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
        public Guid CompanyId { get; private set; }

        /// <summary>
        /// Nome da empresa
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Data de criação da empresa no sistema
        /// </summary>
        public DateTime CreatedOn { get; private set; }


        /// <summary>
        /// Data de modificação da empresa no sistema
        /// </summary>
        public DateTime ModifiedOn { get; private set; }


        /// <summary>
        /// Status da empresa
        /// </summary>
        public ECompanyStatus CompanyStatus { get; private set; }

        /// <summary>
        /// Company Log ID
        /// </summary>
        public Guid CompanyLogId { get; private set; }

        /// <summary>
        /// CompanyLog
        /// </summary>
        public List<CompanyLog> CompanyLogs { get; private set; }

        /// <summary>
        /// Project  ID
        /// </summary>
        public Guid ProjectId { get; private set; }

        /// <summary>
        /// Projects
        /// </summary>
        public List<Project> Projects { get; private set; }


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

        /// <summary>
        /// Método para criação de uma Company
        /// </summary>
        /// <param name="company">Company a ser criada</param>
        /// <returns>Retorna true caso as validações no escopo de criação sejam satisfeitas</returns>
        public bool CreateCompany(Company company)
        {
            if (this.CreateCompanyScopeIsValid())
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Método para obter todos os projetos da Empresa
        /// </summary>
        /// <returns>Retorna uma lista de Projects que pertence à uma Company</returns>
        public List<Project> GetProjectsFromCompany()
        {
            return this.Projects;
        }

        /// <summary>
        /// Método para obter todos os Logs de uma Company
        /// </summary>
        /// <returns>Retorna uma lista de CompanyLog que pertence à uma Company</returns>
        public List<CompanyLog> GetLogsFromCompany()
        {
            return this.CompanyLogs;
        }


        #endregion

    }
}
