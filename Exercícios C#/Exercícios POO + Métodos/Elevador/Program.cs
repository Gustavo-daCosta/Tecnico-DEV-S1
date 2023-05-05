using ClasseElevador;
using ClasseFuncionalidades;

static int Menu() {
    Console.Clear();
    menu:
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($" === SISTEMA DE ELEVADOR ===\n");

    Console.WriteLine($"");

    Console.ResetColor();
    Console.WriteLine(@$"Selecione uma opção:
    [1] - Entrar no elevador
    [2] - Sair do elevador
    [3] - Subir andares do elevador
    [4] - Descer andares do elevador

    [5] - Inicializar o elevador novamente

    [0] - Sair
    ");
    Console.Write($"Digite a opção desejada: ");
    int opcao = int.Parse(Console.ReadLine()!);

    if (opcao < 0 || opcao > 5) {
        Funcionalidades.Mensagem($"Valor inválido digitado! Tente novamente.");
        goto menu;
    }
    return opcao;
}

// Cria uma instância da classe Elevador
Elevador elevador = new Elevador();
// Inicializa o elevador
elevador.Inicializar();
Funcionalidades.Mensagem($"Elevador inicializado com sucesso!", ConsoleColor.Green);

bool desejaContinuar = true;
while (desejaContinuar) {
    int opcao = Menu();

    switch (opcao) {
        case 1:
            elevador.Entrar();
            break;
        case 2:
            elevador.Sair();
            break;
        case 3:
            elevador.Subir();
            break;
        case 4:
            elevador.Descer();
            break;
        default:
            Funcionalidades.Mensagem($"Saindo do programa...");
            Environment.Exit(1);
            break;
    }
}
