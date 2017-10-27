using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esperanto.Domain.Enums.User
{
    public enum EUserRole
    {
        /// <summary>
        /// Usuário do tipo Administrador
        /// </summary>
        Admin = 1,

        /// <summary>
        /// Usuário do tipo Cliente
        /// </summary>
        Client = 2,

        /// <summary>
        /// Usuário Colaborador
        /// </summary>
        Collaborator = 3
    }
}
