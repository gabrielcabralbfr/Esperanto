using Esperanto.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;


namespace Esperanto.Infrastructure.Map
{
    public class UserCompanyMap : EntityTypeConfiguration<UserCompany>
    {
        public UserCompanyMap()
        {
            // Mapeando à qual tabela essa entidade pertence
            ToTable("UserCompany");

            // Informando chave primária
            HasKey(uc => uc.UserCompanyId);

            // Desabilitando geração automática
            Property(uc => uc.UserCompanyId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);


            /* Relacionamentos */
            HasRequired(uc => uc.User);

            HasRequired(uc => uc.Company);
        }
    }
}
