using Esperanto.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Esperanto.Infrastructure.Map
{
    public class UserLogMap : EntityTypeConfiguration<UserLog>
    {

        public UserLogMap()
        {
            // Mapeando à qual tabela essa entidade pertence
            ToTable("UserLog");

            // Informando chave primária
            HasKey(ul => ul.UserLogId);

            // Desabilitando geração automática
            Property(ul => ul.UserLogId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Mapeando para o banco propriedade CreatedOn 
            Property(ul => ul.CreatedOn)
                .IsRequired();

            // Mapeando para o banco propriedade Description 
            Property(ul => ul.Description)
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                .IsRequired();


            /* Relacionamentos */
            HasRequired(ul => ul.User)
                .WithMany(u => u.UserLogs);

            
        }

    }
}
