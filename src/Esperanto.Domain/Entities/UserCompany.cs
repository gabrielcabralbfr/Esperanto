using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esperanto.Domain.Entities
{
    public class UserCompany
    {

        #region Properties

        /// <summary>
        /// UserCompanyId
        /// </summary>
        public Guid UserCompanyId { get; set; }

        /// <summary>
        /// ID do usuário
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Usuário dessa Empresa (Company)
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Company ID
        /// </summary>
        public Guid CompanyId { get; set; }

        /// <summary>
        /// Company desse Usuário
        /// </summary>
        public Company Company { get; set; }

        #endregion

    }
}
