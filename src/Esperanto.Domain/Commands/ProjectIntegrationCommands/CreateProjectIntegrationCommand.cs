using System;


namespace Esperanto.Domain.Commands.ProjectIntegrationCommands
{
    public class CreateProjectIntegrationCommand
    {
        
        #region Constructor

        /// <summary>
        /// Consstrutor quqe recebe os atributos do Objeto ProjectIntegration a ser criado
        /// </summary>
        /// <param name="projectIntegrationId">ID da integração</param>
        /// <param name="serverPath">Caminho do Servidor para a integração</param>
        /// <param name="username">Nome de usuário para a integração</param>
        /// <param name="password">Senha do usuário para integração</param>
        /// <param name="deleteFile">Flag (Boolean) para determinar se o arquivo será deletado</param>
        /// <param name="migrationInterval">Intervalo de migração</param>
        public CreateProjectIntegrationCommand(Guid projectIntegrationId, string serverPath, string username, string password, bool deleteFile, int migrationInterval)
        {
            this.ProjectIntegrationId = projectIntegrationId;
            this.ServerPath = serverPath;
            this.Username = username;
            this.Password = password;
            this.DeleteFile = deleteFile;
            this.FirstMigrationDate = DateTime.Now;
            this.LastMigrationDate = DateTime.Now;
            this.MigrationInterval = migrationInterval;
        }

        #endregion


        #region Properties

        /// <summary>
        /// Project Integration ID
        /// </summary>
        public Guid ProjectIntegrationId { get; set; }

        /// <summary>
        /// Caminho do servidor para integração
        /// </summary>
        public string ServerPath { get; set; }

        /// <summary>
        /// Nome de usuário para a integração
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Senha do usuário para integração
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Caso este campo seja marcado como True, o arquivo de integração será deletado
        /// </summary>
        public bool DeleteFile { get; set; }


        /// <summary>
        /// Data da primeira integração
        /// </summary>
        public DateTime FirstMigrationDate { get; set; }

        /// <summary>
        /// Data da última integração
        /// </summary>
        public DateTime LastMigrationDate { get; set; }

        /// <summary>
        /// Intervalo de migração
        /// </summary>
        public int MigrationInterval { get; set; }

        #endregion
    }
}
