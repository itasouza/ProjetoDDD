using Microsoft.EntityFrameworkCore;
using Projeto.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infrastructure.Data
{
    public class AplicacaoContext :DbContext
    {
        public AplicacaoContext(DbContextOptions<AplicacaoContext>options) :base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contato> Contatos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("TB_CLIENTE");
            modelBuilder.Entity<Contato>().ToTable("TB_CONTATO");

            #region Configurações de Cliente
            modelBuilder.Entity<Cliente>().Property(e => e.CPF)
                .HasColumnType("varchar(11)")
                .IsRequired();

            modelBuilder.Entity<Cliente>().Property(e => e.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();
            #endregion

            #region Configurações de Contato
            modelBuilder.Entity<Contato>().Property(e => e.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<Contato>().Property(e => e.Email)
               .HasColumnType("varchar(100)")
               .IsRequired();

            modelBuilder.Entity<Contato>().Property(e => e.Telefone)
               .HasColumnType("varchar(15)");

            #endregion



        }



    }

}
