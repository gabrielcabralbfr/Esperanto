using System;
using Esperanto.Domain.Enums.Project;

namespace Esperanto.Domain.Commands.ProjectCommands
{
    public class UpdateProjectCommand
    {


        #region Constructor

        public UpdateProjectCommand(Guid projectId, string name, Guid licenseId, Guid permissionId, string description, EFileType fileType, char divisorChar, string fileName, string errorEmail, ESendType sendType, bool ignoreFirstLine)
        {
            ProjectId = projectId;
            Name = name;
            LicenseId = licenseId;
            PermissionId = permissionId;
            Description = description;
            FileType = fileType;
            DivisorChar = divisorChar;
            FileName = fileName;
            ErrorEmail = errorEmail;
            SendType = sendType;
            IgnoreFirstLine = ignoreFirstLine;
            ProjectStatus = EProjectStatus.Active;
        }

        #endregion



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


        #endregion
    }
}
