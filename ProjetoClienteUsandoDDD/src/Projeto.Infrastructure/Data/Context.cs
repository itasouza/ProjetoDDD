using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infrastructure.Data
{
    public class Context :DbContext
    {
        public Context(DbContextOptions<Context>options) :base(options)
        {

        }
    }
}
