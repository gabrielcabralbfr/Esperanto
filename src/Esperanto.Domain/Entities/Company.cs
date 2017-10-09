using Esperanto.Domain.Enums.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esperanto.Domain.Entities
{
    public class Company
    {
        #region Properties
        /// <summary>
        /// Company ID
        /// </summary>
        public Guid CompanyId { get; set; }

        /// <summary>
        /// Nome da empresa
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Data de criação da empresa no sistema
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Descrição da empresa
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Status da empresa
        /// </summary>
        public ECompanyStatus CompanyStatus { get; set; }

        /// <summary>
        /// FK para a entidade do Usuário
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Lista de usuários dessa empresa
        /// </summary>
        public List<User> Users { get; set; }

        /// <summary>
        /// ID do Projeto 
        /// </summary>
        public Guid ProjectId { get; set; }

        public List<Project> MyProperty { get; set; }

        #endregion

    }
}
