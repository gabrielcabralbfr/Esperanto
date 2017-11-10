using Esperanto.Domain.Commands.ProjectIntegrationCommands;
using Esperanto.Domain.Enums.ProjectIntegration;
using Esperanto.Domain.Scopes;
using System;

namespace Esperanto.Domain.Entities
{
    /// <summary>
    /// Entidade para a integração do Projeto
    /// </summary>
    public class ProjectIntegration
    {

        #region Constructor

        /// <summary>
        /// Construtor padrão
        /// </summary>
        protected ProjectIntegration() { }


        /// <summary>
        /// Método construtor da Entidade que recebe um comando de criação
        /// </summary>
        /// <param name="command">Comando de criação com as propriedades da Entidade</param>
        public ProjectIntegration(CreateProjectIntegrationCommand command)
        {
            ProjectIntegrationId = Guid.NewGuid();
            ServerPath = command.ServerPath;
            Username = command.Username;
            Password = command.Password;
            DeleteFile = command.DeleteFile;
            FirstMigrationDate = command.FirstMigrationDate;
            LastMigrationDate = command.LastMigrationDate;
            MigrationInterval = command.MigrationInterval;
            IntervalType = command.IntervalType;
        }

        #endregion


        #region Properties

        /// <summary>
        /// Project Integration ID
        /// </summary>
        public Guid ProjectIntegrationId { get; private set; }

        /// <summary>
        /// Caminho do servidor para integração
        /// </summary>
        public string ServerPath { get; private set; }

        /// <summary>
        /// Nome de usuário para a integração
        /// </summary>
        public string Username { get; private set; }

        /// <summary>
        /// Senha do usuário para integração
        /// </summary>
        public string Password { get; private set; }

        /// <summary>
        /// Caso este campo seja marcado como True, o arquivo de integração será deletado
        /// </summary>
        public bool DeleteFile { get; private set; }


        /// <summary>
        /// Data da primeira integração
        /// </summary>
        public DateTime FirstMigrationDate { get; private set; }

        /// <summary>
        /// Data da última integração
        /// </summary>
        public DateTime LastMigrationDate { get; private set; }

        /// <summary>
        /// Intervalo de migração. Ex: A cada 1 IntervalType.
        /// </summary>
        public int MigrationInterval { get; private set; }

        /// <summary>
        /// Tipo de intervalo entre as migrações. Ex: Dias, Horas, minutos
        /// </summary>
        public EProjectIntegrationIntervalType IntervalType { get; private set; }

        /// <summary>
        /// ID do projeto
        /// </summary>
        public Guid ProjectId { get; private set; }

        /// <summary>
        /// Projeto
        /// </summary>
        public Project Project { get; private set; }
        #endregion


        #region Methods

        /// <summary>
        /// Método de criação de uma integração do projeto
        /// </summary>
        /// <param name="projectIntegration">Integração a ser criada</param>
        /// <returns>Retorna true caso a atualização tenho sido bem sucedida</returns>
        public bool CreateProjectIntegration(ProjectIntegration projectIntegration)
        {
            if (this.CreateProjectIntegrationScopeIsValid())
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Método de atualização de uma integração do projeto
        /// </summary>
        /// <param name="projectIntegration">Integração a ser atualizada</param>
        /// <returns>Retorna true caso a atualização tenho sido bem sucedida</returns>
        public bool UpdateProjectIntegration(ProjectIntegration projectIntegration)
        {
            if (this.UpdateProjectIntegrationScopeIsValid())
            {
                return true;
            }

            return false;
        }


        #endregion

    }
}
