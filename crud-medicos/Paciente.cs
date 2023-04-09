using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_medicos
{
    public class Paciente : Pessoa
    {
        public List<Consulta> Consultas { get; set; } = new List<Consulta>();
    }
}