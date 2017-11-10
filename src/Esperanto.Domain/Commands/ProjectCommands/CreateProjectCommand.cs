using System;
using Esperanto.Domain.Enums.Project;

namespace Esperanto.Domain.Commands.ProjectCommands
{
    public class CreateProjectCommand
    {

        #region Constructor

        /// <summary>
        /// Construtor que recebe os atributos do Objeto Project a ser criados
        /// </summary>
        /// <param name="name">Nome do Projeto</param>
        /// <param name="licenseId">License ID da licença que pertence ao Projeto</param>
        /// <param name="permissionId">Permission ID da base que pertence ao Projeto</param>
        /// <param name="description">Descrição do projeto</param>
        /// <param name="fileType">Tipo de Arquivo que será usado na integração</param>
        /// <param name="divisorChar">Caracter divisor do arquivo</param>
        /// <param name="fileName">Nome do arquivo que será importado</param>
        /// <param name="errorEmail">E-mail em caso de erros na integração do projeto</param>
        /// <param name="sendType">Tipo de Envio</param>
        /// <param name="ignoreFirstLine">Boolean para Ignorar ou não o cabeçalho</param>
        public CreateProjectCommand(string name, Guid licenseId, Guid permissionId, string description, EFileType fileType, char divisorChar, string fileName, string errorEmail, ESendType sendType, bool ignoreFirstLine)
        {
            
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
