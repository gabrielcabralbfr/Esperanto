using Esperanto.Domain.Commands.ProjectCommands;
using Esperanto.Domain.Enums.Project;
using Esperanto.Domain.Scopes;
using System;
using System.Collections.Generic;


namespace Esperanto.Domain.Entities
{
    /// <summary>
    /// Projeto de pesquisa pertencente à uma Company
    /// </summary>
    public class Project
    {

        #region Constructor

        /// <summary>
        /// Construtor padrão
        /// </summary>
        protected Project() { }

        /// <summary>
        /// Construtor que recebe um comando de criação do Projeto
        /// </summary>
        /// <param name="command">Comando de criação</param>
        public Project(CreateProjectCommand command)
        {
            this.ProjectId = Guid.NewGuid();
            this.Name = command.Name;
            this.LicenseId = command.LicenseId;
            this.PermissionId = command.PermissionId;
            this.Description = command.Description;
            this.CreatedOn = DateTime.Now;
            this.ModifiedOn = DateTime.Now;
            this.FileType = command.FileType;
            this.DivisorChar = command.DivisorChar;
            this.FileName = command.FileName;
            this.ErrorEmail = command.ErrorEmail;
            this.SendType = command.SendType;
            this.IgnoreFirstLine = command.IgnoreFirstLine;
            this.ProjectStatus = command.ProjectStatus;
        }

        #endregion


        #region Properties

        /// <summary>
        /// ID do projeto
        /// </summary>
        public Guid ProjectId { get; private set; }

        /// <summary>
        /// Nome do projeto
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// License ID do Projeto
        /// </summary>
        public Guid LicenseId { get; private set; }

        /// <summary>
        /// Permission ID do projeto
        /// </summary>
        public Guid PermissionId { get; private set; }

        /// <summary>
        /// Descrição do projeto
        /// </summary>
        public string Description { get; private set; }


        /// <summary>
        /// Data de criação do Projeto no sistema
        /// </summary>
        public DateTime CreatedOn { get; private set; }


        /// <summary>
        /// Data de modificação do Projeto no sistema
        /// </summary>
        public DateTime ModifiedOn { get; private set; }


        /// <summary>
        /// Tipo de arquivo do projeto
        /// </summary>
        public EFileType FileType { get; private set; }

        /// <summary>
        /// Caracter divisor do arquivo configurado no projeto
        /// </summary>
        public char DivisorChar { get; private set; }

        /// <summary>
        /// Nome do arquivo configurado
        /// </summary>
        public string FileName { get; private set; }

        /// <summary>
        /// E-mail a ser contactado em caso de erro no projeto
        /// </summary>
        public string ErrorEmail { get; private set; }

        /// <summary>
        /// Tipo de envio do arquivo na integração do projeto
        /// </summary>
        public ESendType SendType { get; private set; }

        /// <summary>
        /// Boolean para ignorar a primeira linha do arquivo
        /// </summary>
        public bool IgnoreFirstLine { get; private set; }

        /// <summary>
        /// Status do projeto
        /// </summary>
        public EProjectStatus ProjectStatus { get; private set; }

        /// <summary>
        /// FK da empresa desse projeto
        /// </summary>
        public Guid CompanyId { get; private set; }

        /// <summary>
        /// Empresa desse projeto
        /// </summary>
        public Company Company { get; private set; }

        /// <summary>
        /// FK da integração do projeto
        /// </summary>
        public Guid ProjectIntegrationId { get; private set; }

        /// <summary>
        /// Integração do projeto
        /// </summary>
        public ProjectIntegration ProjectIntegration { get; private set; }


        /// <summary>
        /// FK - ID do Log do Projeto
        /// </summary>
        public Guid ProjectLogId { get; private set; }

        /// <summary>
        /// Project Logs do projeto
        /// </summary>
        public List<ProjectLog> ProjectLogs { get; private set; }

        /// <summary>
        /// FK - Project Field ID
        /// </summary>
        public Guid ProjectFieldId { get; private set; }

        /// <summary>
        /// Lista de Project Fields do Projeto
        /// </summary>
        public List<ProjectField> ProjectFields { get; private set; }
        #endregion


        #region Methods

        /// <summary>
        /// Método para criação de um Project
        /// </summary>
        /// <returns>Retorna true caso as validações do escopo de criação sejam satisfeitas</returns>
        public bool CreateProject()
        {
            if (this.CreateProjectScopeIsValid())
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para atualização de um Project
        /// </summary>
        /// <returns>Retorna true caso as validações do escopo de atualização sejam satisfeitas</returns>
        public bool UpdateProject()
        {
            if (this.UpdateProjectScopeIsValid())
            {
                return true;
            }

            return false;
        }

        public void SendErrorEmail()
        {
            // Not Implemented yet
        }

        /// <summary>
        /// Método para tornar um projeto ativo
        /// </summary>
        public void Activate()
        {
            this.ProjectStatus = EProjectStatus.Active;
        }

        /// <summary>
        /// Método para tornar um projeto inativo
        /// </summary>
        public void Dectivate()
        {
            this.ProjectStatus = EProjectStatus.Active;
        }

        /// <summary>
        /// Método para alterar o tipo de envio do Projeto
        /// </summary>
        /// <param name="newType">Novo tipo de envio</param>
        public void ChangeSendType(ESendType newType)
        {
            this.SendType = newType;
        }

        /// <summary>
        /// Método para alterar o tipo de arquivo do Projeto
        /// </summary>
        /// <param name="newType">Novo tipo de arquivo</param>
        public void ChangeFileType(EFileType newType)
        {
            this.FileType = newType;
        }

        /// <summary>
        /// Método para obter todos os Logs do Projeto
        /// </summary>
        /// <returns>Retorna uma lista de Logs pertencente à um Projeto</returns>
        public List<ProjectLog> GetLogs()
        {
            return this.ProjectLogs;
        }


        /// <summary>
        /// Método para obter todos os campos do arquivo de um Projeto
        /// </summary>
        /// <returns>Retorna uma lista de ProjectField pertencente à um Projeto</returns>
        public List<ProjectField> GetProjectFields()
        {
            return this.ProjectFields;
        }

        #endregion
    }
}
