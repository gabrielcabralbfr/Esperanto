using Esperanto.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Esperanto.Infrastructure.Map
{
    public class CompanyLogMap : EntityTypeConfiguration<CompanyLog>
    {

        public CompanyLogMap()
        {
            // Mapeando à qual tabela essa entidade pertence
            ToTable("CompanyLog");

            // Informando chave primária
            HasKey(cl => cl.CompanyLogId);

            // Desabilitando geração automática
            Property(cl => cl.CompanyLogId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Mapeando para o banco propriedade CreatedOn
            Property(cl => cl.CreatedOn)
                .IsRequired();

            // Mapeando para o banco propriedade Description
            Property(cl => cl.Description)
                .IsRequired()
                .HasMaxLength(250);

            // Mapeando para o banco propriedade LogType
            Property(cl => cl.LogType)
                .IsRequired();

            /* Relacionamentos */
            HasRequired(cl => cl.Company)
                .WithMany(c => c.CompanyLogs);
        }

    }
}
