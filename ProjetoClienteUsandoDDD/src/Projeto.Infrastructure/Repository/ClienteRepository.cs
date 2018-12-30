using Projeto.ApplicationCore.Entity;
using Projeto.ApplicationCore.Interfaces.Repository;
using Projeto.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Projeto.Infrastructure.Repository
{
    public class ClienteRepository : EFRepository<Cliente>, IClienteRepository
    {


        public ClienteRepository(AplicacaoContext dbContext) : base(dbContext)
        {

        }

        //exemplo usando o virtual no Adicionar
        //public override Cliente Adicionar(Cliente entity)
        //{
        //    var verificarResultado = "";
        //    //TODO:implementação especifica para adicionar um cliente 
        //    //fazendo a sobrescrita de método - polimorfismo
        //    _dbContext.Set<Cliente>().Add(entity);
        //    _dbContext.SaveChanges();
        //    return base.Adicionar(entity);
        //}

        public Cliente ObterPorProfissao(int clienteId)
        {
            return Buscar(x => x.ProfissoesClientes.Any(p => p.ClienteId == clienteId))
                .FirstOrDefault();
        }


    }
}
