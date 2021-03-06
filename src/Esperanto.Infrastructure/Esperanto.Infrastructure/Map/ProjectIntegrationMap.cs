﻿using Esperanto.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Esperanto.Infrastructure.Map
{
    public class ProjectIntegrationMap : EntityTypeConfiguration<ProjectIntegration>
    {
        public ProjectIntegrationMap()
        {
            // Mapeando à qual tabela essa entidade pertence
            ToTable("ProjectIntegration");

            // Informando chave primária
            HasKey(pi => pi.ProjectIntegrationId);

            // Desabilitando geração automática
            Property(p => p.ProjectIntegrationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Mapeando para o banco propriedade ServerPath
            Property(pi => pi.ServerPath)
                .HasMaxLength(140)
                .IsRequired();

            // Mapeando para o banco propriedade Username
            Property(pi => pi.Username)
                .HasMaxLength(50)
                .IsRequired();

            // Mapeando para o banco propriedade Password
            Property(pi => pi.Password)
                .HasMaxLength(32)
                .IsRequired();

            // Mapeando para o banco propriedade DeleteFile
            Property(pi => pi.DeleteFile)
                .HasColumnType("bit")
                .IsRequired();

            // Mapeando para o banco propriedade FirstMigrationDate
            Property(pi => pi.FirstMigrationDate)
                .IsRequired();

            // Mapeando para o banco propriedade LastMigrationDate
            Property(pi => pi.LastMigrationDate)
                .IsRequired();

            // Mapeando para o banco propriedade IntervalType
            Property(pi => pi.IntervalType)
                .IsRequired();

            // Mapeando para o banco propriedade MigrationInterval
            Property(pi => pi.MigrationInterval)
                .IsRequired();


            /* Relacionamentos */
            HasRequired(pi => pi.Project);
        }
    }
}
