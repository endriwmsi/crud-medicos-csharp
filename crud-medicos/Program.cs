using crud_medicos;

class Program
{
  static Repository repository = new Repository();

  static void Main(string[] args)
  {
    int opcao = 0;
    MedicoController medicoController = new MedicoController();

    // Loop para o menu de opções
    while (opcao != 6)
    {
      Console.WriteLine("Selecione uma opção:");
      Console.WriteLine("1 - Adicionar médico");
      Console.WriteLine("2 - Listar médicos");
      Console.WriteLine("3 - Marcar consulta");
      Console.WriteLine("4 - Verificar disponibilidade de médico");
      Console.WriteLine("5 - Excluir médico");
      Console.WriteLine("6 - Sair");

      if (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 6)
      {
        Console.WriteLine("Opção inválida. Tente novamente.");
        continue;
      }

      // caso seja uma destas opções, chamar a classe MedicoController e seus respectivos métodos
      switch (opcao)
      {
        case 1:
          medicoController.AdicionarMedico();
          break;
        case 2:
          medicoController.ListarMedicos();
          break;
        case 3:
          medicoController.MarcarConsulta();
          break;
        case 4:
          medicoController.VerificarDisponibilidadeMedico();
          break;
          case 5:
          medicoController.ExcluirMedico();
          break;
          // Caso seja 6, sair do programa
        case 6:
          Console.WriteLine("Saindo do programa...");
          break;
      }
    }
  }
}