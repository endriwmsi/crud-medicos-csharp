using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_medicos
{
    public class Repository
    {
        // Listas de Médicos, Pacientes e Consultas
        private List<Medico> medicos = new List<Medico>();
        private List<Paciente> pacientes = new List<Paciente>();
        private List<Consulta> consultas = new List<Consulta>();


        // Chamando o método de adicionar médicos
        public void AdicionarMedico(Medico medico)
        {
            medicos.Add(medico);
        }

        // Chamando o método de listar médicos
        public List<Medico> ListarMedicos()
        {
            return medicos;
        }


        // Chamando o método de verificar disponibilidade
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
   
        // Chamando o método de marcar consulta
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
   
        // Chamando o método de excluir médico
        public void ExcluirMedico(Medico medico)
        {
            medicos.Remove(medico);
        }
    }
}