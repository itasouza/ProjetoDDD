using Microsoft.EntityFrameworkCore;
using Projeto.ApplicationCore.Entity;
using Projeto.Infrastructure.EntityConfig;
using System;
using System.Linq;

namespace Projeto.Infrastructure.Data
{
    public class AplicacaoContext : DbContext
    {
        public AplicacaoContext(DbContextOptions<AplicacaoContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Profissao> Profissoes { get; set; }
        public DbSet<ProfissaoCliente> ProfissoesCliente { get; set; }
        public DbSet<Menu> Menus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("TB_CLIENTE");
            modelBuilder.Entity<Contato>().ToTable("TB_CONTATO");
            modelBuilder.Entity<Endereco>().ToTable("TB_ENDERECO");
            modelBuilder.Entity<Profissao>().ToTable("TB_PROFISSAO");
            modelBuilder.Entity<ProfissaoCliente>().ToTable("TB_PROFISSAO_CLIENTE");
            modelBuilder.Entity<Menu>().ToTable("TB_MENU");

            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new ContatoMap());
            modelBuilder.ApplyConfiguration(new ProfissaoMap());
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new ProfissaoClienteMap());
            modelBuilder.ApplyConfiguration(new MenuMap());

        }

    
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                    entry.Property("DataAlteracao").IsModified = false;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataAlteracao").CurrentValue = DateTime.Now;
                    entry.Property("DataCadastro").IsModified = false;
                }
            }

            return SaveChanges();
        }


    }

}
