using System;

namespace Esperanto.Domain.Commands.ProjectFieldCommands
{
    public class CreateProjectFieldCommand
    {
        #region Constructor

        /// <summary>
        /// Construtor que recebe atributos do Objeto ProjectField a ser criado
        /// </summary>
        /// <param name="projectFieldId">ID do Project Field</param>
        /// <param name="name">Nome do Campo</param>
        /// <param name="orderPosition">Posição do Campo</param>
        public CreateProjectFieldCommand(Guid projectFieldId, string name, int orderPosition)
        {
            this.ProjectFieldId = projectFieldId;
            this.Name = name;
            this.OrderPosition = orderPosition;
        }

        #endregion

        #region Properties

        /// <summary>
        /// ID do campo
        /// </summary>
        public Guid ProjectFieldId { get; set; }

        /// <summary>
        /// Nome do campo
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Posição do campo 
        /// </summary>
        public int OrderPosition { get; set; }

        #endregion

    }
}
