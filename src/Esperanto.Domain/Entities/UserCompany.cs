using System;


namespace Esperanto.Domain.Entities
{
    /// <summary>
    /// Entidade que representa um usuário de uma company
    /// </summary>
    public class UserCompany
    {

        #region Constructor

        /// <summary>
        /// Construtor padrão
        /// </summary>
        protected UserCompany() { }

        /// <summary>
        /// Construtor para a Entidade UserCompany
        /// </summary>
        /// <param name="userCompanyId">ID da entidade</param>
        /// <param name="userId">ID do User</param>
        /// <param name="user">Entidade User</param>
        /// <param name="companyId">ID da Company</param>
        /// <param name="company">Entidade Company</param>
        public UserCompany(Guid userCompanyId, Guid userId, User user, Guid companyId, Company company)
        {
            UserCompanyId = userCompanyId;
            UserId = userId;
            User = user;
            CompanyId = companyId;
            Company = company;
        }

        #endregion


        #region Properties

        /// <summary>
        /// UserCompanyId
        /// </summary>
        public Guid UserCompanyId { get; private set; }

        /// <summary>
        /// ID do usuário
        /// </summary>
        public Guid UserId { get; private set; }

        /// <summary>
        /// Usuário dessa Empresa (Company)
        /// </summary>
        public User User { get; private set; }

        /// <summary>
        /// Company ID
        /// </summary>
        public Guid CompanyId { get; private set; }

        /// <summary>
        /// Company desse Usuário
        /// </summary>
        public Company Company { get; private set; }

        #endregion


        #region Methods

        /// <summary>
        /// Método para criação da entidade UserCompany
        /// </summary>
        /// <param name="userCompany">UserCompany a ser criada</param>
        /// <returns>Retorna true caso a entidade tenha sido criado, caso ocorra algum erro no processo, retornará false</returns>
        public bool CreateUserCompany(UserCompany userCompany)
        {
            return false; // Not implemented yet
        }

        #endregion
    }
}
