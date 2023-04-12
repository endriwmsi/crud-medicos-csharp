using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_medicos
{
    public class MedicoController
    {
        private Repository repository;

        public MedicoController()
        {
            repository = new Repository();
        }

        // Método para adicionar novos médicos
        public void AdicionarMedico()
        {
            Medico medico = new Medico();
            Console.WriteLine("Digite o nome do médico:");
            medico.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do médico:");
            medico.SetCpf (Console.ReadLine());
            Console.WriteLine("Digite o CRM do médico:");
            medico.CRM = Console.ReadLine();
            Console.WriteLine("Digite a especialidade do médico:");
            medico.Especialidade = Console.ReadLine();
            repository.AdicionarMedico(medico);
            Console.WriteLine("Médico adicionado com sucesso!");
        }

        // Métodos para listar todos médicos ja cadastrados
        public void ListarMedicos()
        {
            List<Medico> medicos = repository.ListarMedicos();
            if (medicos.Count == 0)
            {
                Console.WriteLine("Não há médicos cadastrados.");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Médicos cadastrados:");
                Console.WriteLine("");
                foreach (Medico medico in medicos)
                {
                    Console.WriteLine("Nome: {0}\nCPF: {1}\nCRM: {2}\nEspecialidade: {3}",
                    medico.Nome, medico.GetCpf(), medico.CRM, medico.Especialidade);
                    Console.WriteLine("");
                }
            }
        }

        // Método para verificar a disponibilidade de um médico pelo CRM e data
        public void VerificarDisponibilidadeMedico()
        {
            Console.WriteLine("Digite o CRM do médico:");
            string crm = Console.ReadLine();
            Medico medico = repository.ListarMedicos().FirstOrDefault(m => m.CRM == crm);
            if (medico == null)
            {
                Console.WriteLine("Médico não encontrado.");
            }
            else
            {
                Console.WriteLine("Digite a data e hora da consulta (formato: dd/mm/yyyy hh:mm):");
                if (!DateTime.TryParse(Console.ReadLine(), out DateTime dataHora))
                {
                    Console.WriteLine("Data e hora inválidas. Tente novamente.");
                    return;
                }
                if (repository.VerificarDisponibilidadeMedico(medico, dataHora))
                {
                    Console.WriteLine("Médico disponível na data e hora selecionadas.");
                }
                else
                {
                    Console.WriteLine("Médico não disponível na data e hora selecionadas.");
                }
            }
        }

        // Método para agendar consulta, caso haja disponibilidade de horário, ou exista o médico
        public void MarcarConsulta()
        {
            Console.WriteLine("Digite o CPF do paciente:");
            string cpf = Console.ReadLine();
            Paciente paciente = new Paciente();
            paciente.SetCpf(cpf);
            
            Console.WriteLine("Digite o CRM do médico:");
            string crm = Console.ReadLine();
            Medico medico = repository.ListarMedicos().FirstOrDefault(m => m.CRM == crm);
            if (medico == null)
            {
                Console.WriteLine("Médico não encontrado.");
            }
            else
            {
                Console.WriteLine("Digite a data e hora da consulta (formato: dd/mm/yyyy hh:mm):");
                if (!DateTime.TryParse(Console.ReadLine(), out DateTime dataHora))
                {
                    Console.WriteLine("Data e hora inválidas. Tente novamente.");
                    return;
                }
                try
                {
                    repository.MarcarConsulta(medico, paciente, dataHora);
                    Console.WriteLine("Consulta marcada com sucesso!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        // Método para excluir um médico
        public void ExcluirMedico()
        {
            Console.WriteLine("Digite o CRM do médico a ser excluído:");
            string crm = Console.ReadLine();
            Medico medico = repository.ListarMedicos().FirstOrDefault(m  => m.CRM == crm);

            if (medico == null)
            {
                Console.WriteLine("Médico não encontrado.");
            }
            else
            {
                repository.ExcluirMedico(medico);
                Console.WriteLine("Médico excluído com sucesso!");
            }
        }
    }
}