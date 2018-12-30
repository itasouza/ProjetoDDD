using Projeto.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.ApplicationCore.Interfaces.Repository
{
   public interface IClienteRepository : IRepository<Cliente>
    {
        Cliente ObterPorProfissao(int clienteId);
    }
}
