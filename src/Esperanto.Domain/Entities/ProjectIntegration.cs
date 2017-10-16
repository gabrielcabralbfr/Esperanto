using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esperanto.Domain.Entities
{
    public class ProjectIntegration
    {

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

        /// <summary>
        /// ID do projeto
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// Projeto
        /// </summary>
        public Project Project { get; set; }
        #endregion

    }
}
