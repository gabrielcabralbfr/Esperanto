using Esperanto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esperanto.Infrastructure.Map
{
    public class ProjectFieldMap : EntityTypeConfiguration<ProjectField>
    {
        public ProjectFieldMap()
        {
            // Mapeando à qual tabela essa entidade pertence
            ToTable("ProjectField");

            // Informando chave primária
            HasKey(pf => pf.ProjectFieldId);

            // Desabilitando geração automática
            Property(pf => pf.ProjectFieldId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Mapeando para o banco propriedade Name 
            Property(c => c.Name)
                .HasMaxLength(50)
                .HasColumnType("nvarchar")
                .IsRequired();

            // Mapeando para o banco propriedade OrderPosition 
            Property(c => c.OrderPosition)
                .HasColumnType("int")
                .IsRequired();
        }
    }
}
