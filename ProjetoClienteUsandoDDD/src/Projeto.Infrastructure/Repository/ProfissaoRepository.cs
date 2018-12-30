using Projeto.ApplicationCore.Entity;
using Projeto.ApplicationCore.Interfaces.Repository;
using Projeto.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infrastructure.Repository
{
    public class ProfissaoRepository : EFRepository<Profissao>, IProfissaoRepository
    {

        public ProfissaoRepository(AplicacaoContext dbContext) : base(dbContext)
        {

        }

    }
}
