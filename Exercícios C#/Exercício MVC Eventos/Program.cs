using Exercício_MVC_Eventos.Controller;
using Exercício_MVC_Eventos.Model;

Evento evento = new Evento();
EventoController controller = new EventoController();

// TODO:
// - Corrigir decorações do menu
// - Criar método de mensagem
// - Criar método de Deletar Evento

menu:
Console.Clear();
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($" === SISTEMA DE EVENTOS ===");
Console.ResetColor();
Console.WriteLine(@$"Selecione uma opção:
[1] - Cadastrar evento
[2] - Listar eventos

[0] - Sair do programa
");
Console.Write($"Digite a opção desejada: ");
int opcao = int.Parse(Console.ReadLine()!);

if (opcao < 0 || opcao > 2) {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Opção inválida digitada! Tente novamente.");
    Console.ResetColor();
    Console.Write($"Aperte ENTER para continuar...");
    Console.ReadLine();
    goto menu;
}

switch (opcao) {
    case 1:
        controller.Cadastrar();
        goto menu;
    case 2:
        controller.Listar();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nFim da lista de eventos");
        Console.ResetColor();
        Console.Write($"Aperte ENTER para continuar...");
        Console.ReadLine();
        goto menu;
    default:
        Console.WriteLine($"Saindo do programa...");
        Thread.Sleep(1000);
        Console.Clear();
        Environment.Exit(1);
        break;
}
