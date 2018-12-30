﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.ApplicationCore.Entity;

namespace Projeto.Infrastructure.EntityConfig
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.ClienteId);

            builder
                .HasMany(c => c.Contatos)
                .WithOne(c => c.Cliente)
                .HasForeignKey(c => c.ClienteId)
                .HasPrincipalKey(c => c.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Endereco)
                .WithOne(x => x.Cliente)
                .HasForeignKey<Endereco>(x => x.ClienteId);

            builder.Property(e => e.CPF)
               .HasColumnType("varchar(11)")
               .IsRequired();

            builder.Property(e => e.Nome)
               .HasColumnType("varchar(200)")
               .IsRequired();

            builder.Property(e => e.DataAlteracao)
             .HasColumnType("datetime");

            builder.Property(e => e.DataCadastro)
             .HasColumnType("datetime");
        }
    }
}
