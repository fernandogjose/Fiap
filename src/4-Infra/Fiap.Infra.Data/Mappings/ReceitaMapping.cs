using Fiap.Domain.Entities;
using Fiap.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fiap.Infra.Data.Mappings
{
    public class ReceitaMapping : EntityTypeConfiguration<Receita>
    {
        public override void Map(EntityTypeBuilder<Receita> builder)
        {            
            builder.HasKey(e => e.Id);

            #region Base

            builder.Property(x => x.DataCriacao)
                .HasColumnType("datetime")
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(x => x.DataAlteracao)
                .HasColumnType("datetime")
                .ValueGeneratedOnUpdate();

            builder.Property(x => x.DataExclusao)
                .HasColumnType("datetime");

            builder.Property(x => x.IdUsuarioCriacao);
            builder.Property(x => x.IdUsuarioAlteracao);

            #endregion

            builder.Property(e => e.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(100);

            builder.Property(e => e.Ingredientes)
                .HasColumnType("varchar(max)");
           
            builder.Property(e => e.Preparo)
                .HasColumnType("varchar(max)");

            builder.Property(e => e.TempoPreparo)
                .HasColumnType("int");

            builder.Property(e => e.Tags)
                .HasColumnType("varchar(max)");
               
            builder.Property(e => e.QuantidadePessoas)
                .HasColumnType("int");

            builder.ToTable("Receita");
        }
    }
}
