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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("TB_CLIENTE");
        }



    }

}
