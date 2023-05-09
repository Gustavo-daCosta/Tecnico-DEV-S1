using CambioMoedas;

static void Mensagem(string mensagem, ConsoleColor color = ConsoleColor.Red) {
    Console.ForegroundColor = color;
    Console.WriteLine(mensagem);
    Console.ResetColor();
    Console.Write($"Aperte ENTER para continuar...");
    Console.ReadLine();
    Console.Clear();
}

static int Menu() {
    menu:
    Console.Clear();
    Console.WriteLine($" === CONVERSOR DE MOEDAS ===");
    Console.WriteLine(@$"Selecione uma opção:

    [1] - Converter moeda
    [2] - Listar câmbios de moedas

    [0] - Sair
    ");
    Console.Write($"Digite a opção desejada: ");
    int opcao = int.Parse(Console.ReadLine()!);

    if (opcao < 0 || opcao > 2) {
        Mensagem($"Opção inválida digitada! Tente novamente.");
        goto menu;
    }
    return opcao;
}

bool desejaContinuar = true;
while (desejaContinuar) {
    int opcao = Menu();
}
