using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_medicos
{
    // Classe Medico
    public class Medico : Pessoa
    {
        public string CRM { get; set; }
        public string Especialidade { get; set; }
        public List<Consulta> Consultas { get; set; } = new List<Consulta>();
    }
}