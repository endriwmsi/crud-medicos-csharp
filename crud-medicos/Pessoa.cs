using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_medicos
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}