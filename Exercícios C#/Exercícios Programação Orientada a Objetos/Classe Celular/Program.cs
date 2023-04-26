using Classe_Celular;
using Classe_Contato;
using GlobalsVariables;

static void Mensagem(string mensagem, ConsoleColor color) {
    Console.ForegroundColor = color;
    Console.WriteLine(mensagem);
    Console.ResetColor();
    Console.WriteLine($"Aperte ENTER para continuar...");
    Console.ReadLine();
    Console.Clear();
}

static void Menu(Celular celular) {
    menu:
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($" === CELULAR === ");
    Console.WriteLine($" Estado atual do celular: {celular.VerEstadoCelular()}");
    Console.WriteLine("[1] - " + (celular.estaLigado ? $"Desligar" : "Ligar") + " celular");
    if (celular.estaLigado) {
        Console.WriteLine(@$"
    [2] - Fazer ligação
    [3] - Enviar mensagem

    [0] - Sair do programa
        ");
    }
    Console.Write($"Digite a opção desejada: ");
    int opcao = int.Parse(Console.ReadLine()!);

    if (celular.estaLigado == false && opcao == 1) {
        celular.MudarEstadoCelular();
        Mensagem($"Ligando celular...", ConsoleColor.Green);
        goto menu;
    } else if (opcao != 1) {
        Mensagem("Valor inválido digitado! Tente novamente.", ConsoleColor.Red);
        goto menu;
    }

    if (celular.estaLigado && (opcao >= 0 && opcao <= 3)) {
        switch (opcao) {
            case 1:
                celular.MudarEstadoCelular();
                Mensagem($"Desligando celular...", ConsoleColor.Blue);
                goto menu;
            case 2:
                EntrarEmContato(true, celular);
                break;
            case 3:
                EntrarEmContato(false, celular);
                break;
            default:
                Mensagem("Valor inválido digitado! Tente novamente.", ConsoleColor.Red);
                goto menu;
        }
    } else {
        Mensagem("Valor inválido digitado! Tente novamente.", ConsoleColor.Red);
        goto menu;
    }
}

static void EntrarEmContato(bool eLigacao, Celular celular) {
    menu:
    Console.Clear();
    Console.WriteLine(eLigacao ? " === FAZER LIGAÇÀO ===" : " === ENVIAR MENSAGEM ===");
    Console.WriteLine(eLigacao ? "[1] - Ligar para um número não salvo" : "[1] - Enviar mensagem para um número não salvo");
    Console.WriteLine(eLigacao ? "[2] - Ligar para um número da lista de contatos" : "[2] - Enviar mensagem para um número da lista de contatos");
    Console.WriteLine(@$" [3] - Salvar um novo contato
[4] - Ver lista de contatos

[0] - Voltar ao Menu
");
    Console.Write($"Digite a opção desejada: ");
    int opcao = int.Parse(Console.ReadLine()!);

    Contato contato = new Contato();

    switch (opcao) {
        case 1:
            celular.FazerLigacao();
            goto menu;
        case 2:
            celular.EnviarMensagem();
            goto menu;
        case 3:
            bool contatoAdicionado = AdicionarContato(contato);
            Mensagem(contatoAdicionado ? "Contato adicionado com sucesso!" : "O telefone já foi adicionado a um contato! Tente novamente", contatoAdicionado ? ConsoleColor.Green : ConsoleColor.Red);
            goto menu;
        case 4:
            bool listagemFeita = contato.ListarContatos();
            Mensagem(listagemFeita ? "Listagem completa!" : "Nenhum contato foi salvo!", listagemFeita ? ConsoleColor.Green : ConsoleColor.Red);
            goto menu;
        default:
            Mensagem("ERRO! Opção inválida.", ConsoleColor.Red);
            goto menu;
    }
}

static bool AdicionarContato(Contato contato) {
    if (Globals.contatos.Any()) {
        foreach (Contato contatoGravado in Globals.contatos) {
            if (contatoGravado.telefone == contato.telefone) {
                return false;
            }
        }
    }
    Globals.contatos.Add(contato);
    return true;
}

Celular celular = new Celular();

Menu(celular);
