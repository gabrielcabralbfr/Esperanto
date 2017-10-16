using Esperanto.Domain.Enums.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esperanto.Domain.Entities
{
    public class Project
    {

        #region Properties

        /// <summary>
        /// ID do projeto
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// Nome do projeto
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// License ID do Projeto
        /// </summary>
        public Guid LicenseId { get; set; }

        /// <summary>
        /// Permission ID do projeto
        /// </summary>
        public Guid PermissionId { get; set; }

        /// <summary>
        /// Descrição do projeto
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Tipo de arquivo do projeto
        /// </summary>
        public EFileType FileType { get; set; }

        /// <summary>
        /// Caracter divisor do arquivo configurado no projeto
        /// </summary>
        public char DivisorChar { get; set; }

        /// <summary>
        /// Nome do arquivo configurado
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// E-mail a ser contactado em caso de erro no projeto
        /// </summary>
        public string ErrorEmail { get; set; }

        /// <summary>
        /// Tipo de envio do arquivo na integração do projeto
        /// </summary>
        public ESendType SendType { get; set; }

        /// <summary>
        /// Boolean para ignorar a primeira linha do arquivo
        /// </summary>
        public bool IgnoreFirstLine { get; set; }

        /// <summary>
        /// Status do projeto
        /// </summary>
        public EProjectStatus ProjectStatus { get; set; }

        /// <summary>
        /// FK da empresa desse projeto
        /// </summary>
        public Guid CompanyId { get; set; }

        /// <summary>
        /// Empresa desse projeto
        /// </summary>
        public Company Company { get; set; }

        /// <summary>
        /// FK da integração do projeto
        /// </summary>
        public Guid ProjectIntegrationId { get; set; }

        /// <summary>
        /// Integração do projeto
        /// </summary>
        public ProjectIntegration ProjectIntegration { get; set; }


        /// <summary>
        /// FK - ID do Log do Projeto
        /// </summary>
        public Guid ProjectLogId { get; set; }

        /// <summary>
        /// Project Logs do projeto
        /// </summary>
        public List<ProjectLog> ProjectLogs { get; set; }

        /// <summary>
        /// FK - Project Field ID
        /// </summary>
        public Guid ProjectField { get; set; }

        /// <summary>
        /// Lista de Project Fields do Projeto
        /// </summary>
        public List<ProjectField> ProjectFields { get; set; }
        #endregion

    }
}
