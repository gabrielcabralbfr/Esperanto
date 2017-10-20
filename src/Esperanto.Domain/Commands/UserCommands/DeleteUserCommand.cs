using System;

namespace Esperanto.Domain.Commands.UserCommands
{
    public class DeleteUserCommand
    {

        #region Constructor

        /// <summary>
        /// Construtor que recebe o ID do usuário a ser deletado
        /// </summary>
        /// <param name="userId">ID do usuário a ser deletado</param>
        public DeleteUserCommand(Guid userId)
        {
            this.UserId = userId;
        }

        #endregion


        #region Properties

        /// <summary>
        /// ID do usuário a ser deletado
        /// </summary>
        public Guid UserId { get; set; }


        #endregion
    }
}
