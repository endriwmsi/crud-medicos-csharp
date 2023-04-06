using crud_medicos;

class Program {
  static void Main(string[] args) {

    int opcao;

    do
    {
      Console.WriteLine("Selecione uma opção:");
      Console.WriteLine("1 - Adicionar médico");
      Console.WriteLine("2 - Listar médicos");
      Console.WriteLine("3 - Verificar disponibilidade de médico");
      Console.WriteLine("4 - Agendar consulta");
      Console.WriteLine("0 - Sair");

      if (!int.TryParse(Console.ReadLine(), out opcao))
      {
        Console.WriteLine("Opção inválida!");
        continue;
      }

      switch (opcao)
      {
        case 1:
          // Método adicionar médico
          break;
        case 2:
          // Método Listar médicos
          break;
        case 3:
          // Método Verificar disponibilidade de médico
          break;
        case 4:
          // Método Agendar consulta
        case 0:
          // Sair do programa
          break;
        default:
        Console.WriteLine("Opção inválida!");
        break;
      }
      Console.WriteLine();
    } while (opcao != 0);
  }    
}