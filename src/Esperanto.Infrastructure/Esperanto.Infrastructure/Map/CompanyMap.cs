using Esperanto.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;


namespace Esperanto.Infrastructure.Map
{
    public class CompanyMap : EntityTypeConfiguration<Company>
    {
        public CompanyMap()
        {
            // Mapeando à qual tabela essa entidade pertence
            ToTable("Company");

            // Informando chave primária
            HasKey(c => c.CompanyId);

            // Desabilitando geração automática
            Property(c => c.CompanyId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Mapeando para o banco propriedade Name 
            Property(c => c.Name)
                .HasMaxLength(50)
                .HasColumnType("nvarchar")
                .IsRequired();

            // Mapeando para o banco propriedade CreatedOn 
            Property(c => c.CreatedOn)
                .IsRequired();

            // Mapeando para o banco propriedade ModifiedOn 
            Property(c => c.ModifiedOn)
                .IsRequired();

            // Mapeando para o banco propriedade CompanyStatus 
            Property(c => c.CompanyStatus)
                .HasColumnType("nvarchar")
                .IsRequired();

        }
    }
}
