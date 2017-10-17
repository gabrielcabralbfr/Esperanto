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
                .HasMaxLength(500)
                .IsRequired();


            // Definindo relacionamento
            HasRequired(ul => ul.User);
        }

    }
}
