using System;


namespace Esperanto.Domain.Commands.ProjectCommands
{
    public class DeleteProjectCommand
    {
        #region Constructor

        /// <summary>
        /// Construtor ue recebe o ID do projeto a ser deletado
        /// </summary>
        /// <param name="projectId">ID do projeto a ser deletado</param>
        public DeleteProjectCommand(Guid projectId)
        {
            this.ProjectId = projectId;
        }
        #endregion

        #region Properties

        /// <summary>
        /// Guid com o ID do Project a ser deletado
        /// </summary>
        public Guid ProjectId { get; set; }


        #endregion
    }
}
