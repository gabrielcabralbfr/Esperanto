﻿using Esperanto.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

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
                .IsRequired();

            // Mapeando para o banco propriedade PermissionId 
            Property(p => p.PermissionId)
                .IsRequired();

            // Mapeando para o banco propriedade Description 
            Property(p => p.Description)
                .HasMaxLength(500)
                .IsRequired();

            // Mapeando para o banco propriedade CreateOn 
            Property(p => p.CreatedOn)
                .IsRequired();


            // Mapeando para o banco propriedade ModifiedOn 
            Property(p => p.CreatedOn)
                .IsRequired();


            // Mapeando para o banco propriedade FileType 
            Property(p => p.FileType)
                .IsRequired();

            //Mapeando para o banco a propriedade FileName
            Property(p => p.FileName)
                .IsRequired()
                .HasMaxLength(100);

            // Mapeando para o banco propriedade ErrorEmail 
            Property(p => p.ErrorEmail)
                .IsRequired();

            // Mapeando para o banco propriedade SendType 
            Property(p => p.SendType)
                .IsRequired();

            // Mapeando para o banco propriedade IgnoreFirstLine 
            Property(p => p.IgnoreFirstLine)
                .IsRequired();

            // Mapeando para o banco propriedade ProjectStatus 
            Property(p => p.ProjectStatus)
                .IsRequired();


            /* Relacionamentos */

            HasRequired(p => p.Company)
                .WithMany(c => c.Projects);

        }
    }
}
