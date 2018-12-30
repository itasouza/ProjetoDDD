using Projeto.ApplicationCore.Entity;
using Projeto.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Projeto.ApplicationCore.Services
{
    public class ClienteService : IClienteService
    {
        public Cliente Adicionar(Cliente entity)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Cliente entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> Buscar(Expression<Func<Cliente, bool>> predicado)
        {
            throw new NotImplementedException();
        }

        public Cliente ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(Cliente entity)
        {
            throw new NotImplementedException();
        }
    }
}
