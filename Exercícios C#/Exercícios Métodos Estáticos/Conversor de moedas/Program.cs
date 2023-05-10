using CambioMoedas;
using ClasseMoeda;

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

static void MenuMoedas() {
    float valor = 0;
    int[] moedas = new int[2];

    for (int i = 0; i < 2; i++) {
        menu:
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(i == 1 ? " === CONVERTER MOEDA - Moeda de origem ===" : " === CONVERTER MOEDA - Moeda de destino ===");
        Console.ResetColor();
        Console.WriteLine(i == 1 ? "Selecione a moeda de ORIGEM:" : "Seleciona a moeda de DESTINO:");
        int count = 0;
        foreach (Moeda moeda in Cambio.Moedas) {
            count++;
            Console.WriteLine($"    [{count}] {moeda.Sigla} - {moeda.Nome}");
        }
        Console.Write($"Digite a opção desejada: ");
        int opcao = int.Parse(Console.ReadLine()!);

        if (opcao <= 0 || opcao > Cambio.Moedas.Count()) {
            Mensagem($"Opção inválida digitada! Tente novamente.");
            goto menu;
        }
        moedas.Append(moedas[opcao - 1]);
    }

    menuValor:
    Console.Clear();
    Console.WriteLine($"Digite o valor em ");
}

MenuMoedas();

// bool desejaContinuar = true;
// while (desejaContinuar) {
//     int opcao = Menu();

//     switch (opcao) {
//         case 1:
//             MenuMoedas();
//             break;
//         case 2:
//             Cambio.ListarMoedas();
//             break;
//         default:
//             Mensagem($"Finalizando programa...");
//             desejaContinuar = false;
//             break;
//     }
// }
