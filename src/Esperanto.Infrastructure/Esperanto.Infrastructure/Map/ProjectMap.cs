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
    public class ProjectMap : EntityTypeConfiguration<Project>
    {
        public ProjectMap()
        {
            // Mapeando à qual tabela essa entidade pertence
            ToTable("Project");

            // Informando chave primária
            HasKey(p => p.ProjectId);

            // Desabilitando geração automática
            Property(p => p.ProjectId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Mapeando para o banco propriedade Name 
            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            // Mapeando para o banco propriedade LicenseId 
            Property(p => p.LicenseId)
                .IsRequired()
                .HasColumnType("nvarchar");

            // Mapeando para o banco propriedade PermissionId 
            Property(p => p.PermissionId)
                .IsRequired()
                .HasColumnType("nvarchar");

            // Mapeando para o banco propriedade Description 
            Property(p => p.Description)
                .HasMaxLength(500)
                .IsRequired();

            // Mapeando para o banco propriedade FileType 
            Property(p => p.FileType)
                .IsRequired()
                .HasColumnType("nvarchar");

            // Mapeando para o banco propriedade ErrorEmail 
            Property(p => p.ErrorEmail)
                .IsRequired();

            // Mapeando para o banco propriedade SendType 
            Property(p => p.SendType)
                .IsRequired()
                .HasColumnType("nvarchar");

            // Mapeando para o banco propriedade IgnoreFirstLine 
            Property(p => p.IgnoreFirstLine)
                .IsRequired()
                .HasColumnType("bit");

            // Mapeando para o banco propriedade ProjectStatus 
            Property(p => p.ProjectStatus)
                .IsRequired()
                .HasColumnType("nvarchar");


            /* Relacionamentos */

            HasRequired(p => p.Company)
                .WithMany(c => c.Projects);

            HasRequired(p => p.ProjectIntegration);
        }
    }
}
