using System;

namespace Esperanto.Domain.Commands.CompanyCommands
{
    public class DeleteCompanyCommand
    {
        #region Constructor

        public DeleteCompanyCommand(Guid companyId)
        {
            this.CompanyId = companyId;
        }

        #endregion


        #region Properties

        /// <summary>
        /// ID da Company a ser deletada
        /// </summary>
        public Guid CompanyId { get; set; }

        #endregion
    }
}
