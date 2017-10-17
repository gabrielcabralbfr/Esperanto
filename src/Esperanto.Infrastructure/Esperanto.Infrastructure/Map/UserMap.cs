using Esperanto.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace Esperanto.Infrastructure.Map
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Mapeando à qual tabela essa entidade pertence
            ToTable("User");

            // Informando chave primária
            HasKey(u => u.UserId);

            // Desabilitando geração automática
            Property(u => u.UserId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);


            // Mapeando para o banco propriedade Name 
            Property(u => u.Name)
                .HasColumnName("Name")
                .HasColumnType("nvarchar")
                .IsRequired();

            // Mapeando para o banco propriedade Email 
            Property(u => u.Email)
                .HasColumnName("Email")
                .HasColumnType("nvarchar")
                .IsRequired();

            // Mapeando para o banco propriedade Password
            Property(u => u.Password)
                .HasColumnName("Password")
                .HasColumnType("nvarchar")
                .IsRequired();

            // Mapeando para o banco propriedade CreatedOn
            Property(u => u.CreatedOn)
                .IsRequired();

            // Mapeando para o banco propriedade ModifiedOn
            Property(u => u.ModifiedOn)
                .IsRequired();

            // Mapeando para o banco propriedade UserStatus
            Property(u => u.UserStatus)
                .IsRequired();

            // Mapeando para o banco propriedade UserRole
            Property(u => u.UserRole)
                .IsRequired();

            // Mapeando para o banco propriedade ApiKey
            Property(u => u.ApiKey)
                .IsRequired();


            // Definindo relacionamento
            HasMany(u => u.UserLogs)
                .WithRequired(ul => ul.User);
        }
    }
}
