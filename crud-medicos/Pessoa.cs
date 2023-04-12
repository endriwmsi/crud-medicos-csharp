using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_medicos
{
    public abstract class Pessoa
    {   
        // Atributos da Classe Pessoa, que será a classe que dará vida à Medico e Paciente
        public string Nome { get; set; }
        private string cpf;
        public string Telefone { get; set; }
        public string Email { get; set; }

        public string GetCpf()
        {
            return cpf;
        }

        public void SetCpf(string cpf)
        {
            this.cpf = cpf;
        }
    }
}