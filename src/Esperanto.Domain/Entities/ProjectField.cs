using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esperanto.Domain.Entities
{
    public class ProjectField
    {

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

        /// <summary>
        /// FK para entidade Project
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// Projeto desse Campo
        /// </summary>
        public Project Project { get; set; }

        #endregion

    }
}
