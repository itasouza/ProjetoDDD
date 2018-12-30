using Projeto.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto.Infrastructure.Data
{
   public static class DbInitializer
    {

        public static void Initialize(AplicacaoContext context)
        {
            if (context.Clientes.Any())
            {
                return;
            }

            var clientes = new Cliente[]
            {
                new Cliente{
                    Nome = "José da Silva",
                    CPF = "25213557040"
                },
                new Cliente{
                    Nome = "Maria da Silva",
                    CPF = "14110336040"
                },
               new Cliente{
                    Nome = "Vania Maria Souza",
                    CPF = "93602779084"
                }

            };

            context.AddRange(clientes);

            var contatos = new Contato[]
            {
                new Contato{
                    Nome = "Contato 01",
                    Telefone = "11983330842",
                    Email = "emailcontato1@gmail.com",
                    Cliente = clientes[0]
                },
                new Contato{
                    Nome = "Contato 02",
                    Telefone = "119865656",
                    Email = "emailcontato2@gmail.com",
                    Cliente = clientes[1]
                }
               
            };

            context.AddRange(contatos);
            context.SaveChanges();
        }
    }
}
