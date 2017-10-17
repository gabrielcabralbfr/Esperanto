using Esperanto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esperanto.Infrastructure.Context
{
    public class StoreDataContext : DbContext
    {
        #region Constructor
        public StoreDataContext() : base("Esperanto")
        {

        }
        #endregion

        #region Properties

        /// <summary>
        /// Dbset para a entidade usuário
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Dbset para a entidade UserCompanies
        /// </summary>
        public DbSet<UserCompany> UserCompanies { get; set; }

        /// <summary>
        /// Dbset para a entidade Userlog
        /// </summary>
        public DbSet<UserLog> UserLogs { get; set; }

        /// <summary>
        /// Dbset para a entidade Company
        /// </summary>
        public DbSet<Company> Companies { get; set; }

        /// <summary>
        /// Dbset para a entidade CompanyLog
        /// </summary>
        public DbSet<CompanyLog> CompanyLogs { get; set; }

        /// <summary>
        /// Dbset para a entidade Project
        /// </summary>
        public DbSet<Project> Projects { get; set; }

        /// <summary>
        /// Dbset para a entidade ProjectField
        /// </summary>
        public DbSet<ProjectField> ProjectFields { get; set; }

        /// <summary>
        /// Dbset para a entidade ProjectIntegration
        /// </summary>
        public DbSet<ProjectIntegration> ProjectIntegrations { get; set; }

        /// <summary>
        /// Dbset para a entidade ProjectLog
        /// </summary>
        public DbSet<ProjectLog> ProjectLogs { get; set; }

        #endregion

        #region Methods
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

        }

        #endregion
    }
}
