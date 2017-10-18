using Esperanto.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;



namespace Esperanto.Infrastructure.Map
{
    public class ProjectLogMap : EntityTypeConfiguration<ProjectLog>
    {
        public ProjectLogMap()
        {
            // Mapeando à qual tabela essa entidade pertence
            ToTable("ProjectLog");

            // Informando chave primária
            HasKey(pl => pl.ProjectLogId);

            // Desabilitando geração automática
            Property(pl => pl.ProjectLogId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Mapeando para o banco propriedade CreatedOn 
            Property(pl => pl.CreatedOn)
                .IsRequired();

            // Mapeando para o banco propriedade Description
            Property(pl => pl.Description)
                .HasMaxLength(500)
                .IsRequired();

            // Mapeando para o banco propriedade LogType
            Property(pl => pl.LogType)
                .IsRequired();



            /* Relacionamentos */
            HasRequired(pl => pl.Project)
                .WithMany(p => p.ProjectLogs);
        }
    }
}
