using Esperanto.Domain.Enums.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esperanto.Domain.Entities
{
    public class User
    {
        #region Constructor
        public User(string name, string email, string password, EUserRole userRole)
        {
            UserId = Guid.NewGuid();
            this.Name = name;
            this.Email = email;
            this.Password = password;
            CreatedOn = DateTime.Now;
            this.UserStatus = EUserStatus.Active;
            UserRole = userRole;

        }
        #endregion

        #region Properties
        /// <summary>
        /// ID do usuário
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Nome do usuário
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// E-mail do usuário
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Senha do usuário
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Data de criação do usuário
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Data de modificação do usuário
        /// </summary>
        public DateTime ModifiedOn { get; set; }

        /// <summary>
        /// Status do usuário
        /// </summary>
        public EUserStatus UserStatus { get; set; }

        /// <summary>
        /// Perfil do cliente
        /// </summary>
        public EUserRole UserRole { get; set; }

        /// <summary>
        /// Key para API
        /// </summary>
        public Guid ApiKey { get; set; }

        /// <summary>
        /// FK para a entidade Company
        /// </summary>
        public Guid CompanyId { get; set; }

        /// <summary>
        /// Lista de Company do usuário
        /// </summary>
        public List<Company> Company { get; set; }

        /// <summary>
        /// FK para a entidade UserLog
        /// </summary>
        public Guid UserLogId { get; set; }

        /// <summary>
        /// Lista de UserLogs do usuário
        /// </summary>
        public List<UserLog> UserLogs { get; set; }

        #endregion

    }
}
