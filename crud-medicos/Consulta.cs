using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_medicos
{
    public class Consulta
    {
        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }
        public DateTime DataHora { get; set; }
    }
}