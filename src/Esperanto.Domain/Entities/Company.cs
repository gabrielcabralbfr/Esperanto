﻿using Esperanto.Domain.Enums.Company;
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
        /// Data de modificação da empresa no sistema
        /// </summary>
        public DateTime ModifiedOn { get; set; }


        /// <summary>
        /// Status da empresa
        /// </summary>
        public ECompanyStatus CompanyStatus { get; set; }

        /// <summary>
        /// Company Log ID
        /// </summary>
        public Guid CompanyLogId { get; set; }

        /// <summary>
        /// CompanyLog
        /// </summary>
        public List<CompanyLog> CompanyLogs { get; set; }

        /// <summary>
        /// Project  ID
        /// </summary>
        public Guid ProjectId { get; set; }

        /// <summary>
        /// Projects
        /// </summary>
        public List<Project> Projects { get; set; }


        #endregion

    }
}
