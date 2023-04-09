using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_medicos 
{
    public class Repository
    {
        private List<Medico> medicos = new List<Medico>();
        private List<Paciente> pacientes = new List<Paciente>();
        private List<Consulta> consultas = new List<Consulta>();

        public void AdicionarMedico(Medico medico)
        {
            medicos.Add(medico);
        }

        public List<Medico> ListarMedicos()
        {
            return medicos;
        }

        public bool VerificarDisponibilidadeMedico(Medico medico, DateTime dataHora)
        {
            foreach (Consulta consulta in medico.Consultas)
            {
                if (consulta.DataHora == dataHora)
                {
                    return false;
                }
            }
            return true;
        }

        public void MarcarConsulta(Medico medico, Paciente paciente, DateTime dataHora)
        {
            if (!VerificarDisponibilidadeMedico(medico, dataHora))
            {
                throw new Exception("Médico não disponível na data e hora selecionadas.");
            }

            Consulta consulta = new Consulta()
            {
                Medico = medico,
                Paciente = paciente,
                DataHora = dataHora
            };

            medico.Consultas.Add(consulta);
            paciente.Consultas.Add(consulta);
            consultas.Add(consulta);
        }

        public void ExcluirMedico(Medico medico)
        {
            medicos.Remove(medico);
        }
    }
}