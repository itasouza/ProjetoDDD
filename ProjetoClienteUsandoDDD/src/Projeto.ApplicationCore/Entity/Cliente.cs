﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.ApplicationCore.Entity
{
   public class Cliente
    {
        public Cliente()
        {

        }

        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        //um cliente tem vários contatos
        public ICollection<Contato> Contatos { get; set; }
        public Endereco Endereco  { get; set; }
        public ICollection<ProfissaoCliente> ProfissoesClientes { get; set; }
    }
}
