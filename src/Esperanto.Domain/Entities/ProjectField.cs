using Esperanto.Domain.Commands.ProjectFieldCommands;
using Esperanto.Domain.Scopes;
using System;

namespace Esperanto.Domain.Entities
{
    /// <summary>
    /// Entidade para os campos do arquivo que será 
    /// </summary>
    public class ProjectField
    {

        #region Constructor

        /// <summary>
        /// Método construtor que recebe o comando de criação da Entidade ProjectField
        /// </summary>
        /// <param name="command">Comando de criação do campo do Projeto</param>
        public ProjectField(CreateProjectFieldCommand command)
        {
            ProjectFieldId = Guid.NewGuid();
            Name = command.Name;
            OrderPosition = command.OrderPosition;
        }

        /// <summary>
        /// Construtor padrão
        /// </summary>
        protected ProjectField() { }

        #endregion


        #region Properties

        /// <summary>
        /// ID do campo
        /// </summary>
        public Guid ProjectFieldId { get; private set; }

        /// <summary>
        /// Nome do campo
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Posição do campo 
        /// </summary>
        public int OrderPosition { get; private set; }

        /// <summary>
        /// FK para entidade Project
        /// </summary>
        public Guid ProjectId { get; private set; }

        /// <summary>
        /// Projeto desse Campo
        /// </summary>
        public Project Project { get; private set; }

        #endregion


        #region Methods

        /// <summary>
        /// Método para criação de um Campo de um arquivo do Projeto 
        /// </summary>
        /// <param name="projectField">Campo a ser criado</param>
        /// <returns>Retorna true caso a validação seja satisfeita e o campo possa ser criado</returns>
        public bool CreateProjectField(ProjectField projectField)
        {
            if (projectField.CreateProjectFieldScopeIsValid())
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Método para edição de um Campo de um arquivo do Projeto
        /// </summary>
        /// <param name="projectField"></param>
        /// <returns>Retorna true caso a validação seja satisfeita e o campo possa ser criado</returns>s
        public bool UpdateProjectField(ProjectField projectField)
        {
            if (this.UpdateProjectFieldScopeIsValid())
            {
                return true;
            }

            return false;
        }

        #endregion
    }
}
