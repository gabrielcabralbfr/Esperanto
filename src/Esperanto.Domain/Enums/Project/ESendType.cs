using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esperanto.Domain.Enums.Project
{
    public enum ESendType
    {
        /// <summary>
        /// Envio de arquivo manual
        /// </summary>
        Manual = 1,

        /// <summary>
        /// Envio de arquivo via FTP
        /// </summary>
        FTP = 2,

        /// <summary>
        /// Envio de arquivo via API
        /// </summary>
        API = 3
    }
}
