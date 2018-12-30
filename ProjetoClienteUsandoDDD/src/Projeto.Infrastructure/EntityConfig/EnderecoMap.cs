using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.ApplicationCore.Entity;


namespace Projeto.Infrastructure.EntityConfig
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.Property(end => end.Bairro)
               .HasColumnType("varchar(200)")
               .IsRequired();

            builder.Property(end => end.CEP)
               .HasColumnType("varchar(15)")
               .IsRequired();

            builder.Property(end => end.Logradouro)
               .HasColumnType("varchar(200)")
               .IsRequired();

            builder.Property(end => end.Referencia)
               .HasColumnType("varchar(400)");

            builder.Property(e => e.DataAlteracao)
            .HasColumnType("datetime");

            builder.Property(e => e.DataCadastro)
             .HasColumnType("datetime");
        }
    }
}