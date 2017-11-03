using Esperanto.Domain.Entities;
using Esperanto.Infrastructure.Map;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


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

            modelBuilder.Configurations.Add(new CompanyLogMap());
            modelBuilder.Configurations.Add(new CompanyMap());
            modelBuilder.Configurations.Add(new ProjectIntegrationMap());
            modelBuilder.Configurations.Add(new ProjectLogMap());
            modelBuilder.Configurations.Add(new ProjectMap());
            modelBuilder.Configurations.Add(new UserCompanyMap());
            modelBuilder.Configurations.Add(new UserLogMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new ProjectFieldMap());

        }

        #endregion
    }
}
