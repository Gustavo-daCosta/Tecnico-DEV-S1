// MOSTRAR MENU
// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.
// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:
// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair

// Funcionalidades adicionais:
// - Sistema de login/cadastro completo e funcional

Console.OutputEncoding = System.Text.Encoding.UTF8;

// MÉTODOS PARA FUNCIONALIDADES
static void Mensagem(string mensagem, ConsoleColor color = ConsoleColor.Red) {
    Console.Clear();
    Console.ForegroundColor = color;
    Console.WriteLine(mensagem);
    Console.ResetColor();
    Console.Write($"Pressione ENTER para continuar...");
    Console.ReadLine();
    Console.Clear();
}

static bool UsuarioExiste(List<string> conta) {
    bool usuarioExiste = false;

    if (Globals.dados.Any()) {
        foreach (List<string> dado in Globals.dados) {
            if (dado[0] == conta[0]) {
                usuarioExiste = true;
                break;
            }
        }
    }
    return usuarioExiste;
}

// MÉTODOS PRINCIPAIS
static int Menu(string mensagem) {
    menu:
    Console.WriteLine(mensagem);
    Console.Write($"Selecione uma opção: ");
    int opcao = int.Parse(Console.ReadLine()!);

    if (opcao < 0 || opcao > 2) {
        Mensagem("Opção inválida digitada! Tente novamente.");
        goto menu;
    }

    return opcao;
}

static void MenuInicial() {
    int opcao = Menu(@$" === Entre na sua conta para registrar sua passagem! === 

    - Você deseja fazer login ou cadastrar uma nova conta?

    [1] Fazer Log-in
    [2] Cadastrar uma nova conta

    [0] Encerrar programa
    ");

    if (opcao == 0) {
        Mensagem($"Encerrando o programa...");
        Environment.Exit(1);
    } else {
        MenuCadastroLogin(opcao);
    }
}

static void MenuCadastroLogin(int opcao) {
    Console.Clear();
    Console.WriteLine(opcao == 1 ? "Faça log-in na sua conta!" : "Cadastre uma nova conta!");

    usuario:
    Console.Write($"Digite o seu usuário: ");
    string usuario = Console.ReadLine()!;

    if (usuario.Length < 2 || usuario.Length > 32) {
        Mensagem($"Nome de usuário inválido, digite um usuáio que tenha entre 2 e 32 caracteres");
        goto usuario;
    }

    senha:
    Console.Write($"Digite a sua senha (mínimo 6 caracteres): ");
    string senha = Console.ReadLine()!;

    if (senha.ToString().Length < 6 || senha.ToString().Length > 16) {
        Mensagem($"Senha inválida, digite uma senha que tenha entre 6 e 16 caracteres");
        goto senha;
    }
    List<string> conta = new List<string>{usuario, senha};

    if (UsuarioExiste(conta) && opcao == 2) {
        Console.WriteLine("O usuário digitado já existe! Tente novamente.");
        goto usuario;
    }

    if (opcao == 1) {
        if (UsuarioExiste(conta)) {
            bool senhaValida = false;
            foreach (List<string> item in Globals.dados) {
                if (item[0] == conta[0]) {
                    senhaValida = item[1] == conta[1] ? true : false;
                    break;
                }
            }

            if (senhaValida) {
                Mensagem($"Login Concluído! Bem-vindo {conta[0]}!", ConsoleColor.Green);
                MenuPassagens();
            } else {
                Mensagem($"A senha digitada está incorreta!");
                goto senha;
            }
        } else {
            Mensagem($"O usuário digitado não existe!");
            goto usuario;
        }
    } else {
        Globals.dados.Add(conta);
        Mensagem($"Cadastro concluído!", ConsoleColor.Green);

        MenuInicial();
    }
}

static void MenuPassagens() {
    Console.Clear();
    int opcao = Menu(@$" === CONTROLE DE PASSAGENS AÉREAS === 

    [1] Cadastrar passagem
    [2] Listar passagens

    [0] Sair da conta
    ");
    
    if (opcao == 1) {
        CadastrarPassagem();
    } else if (opcao == 2) {
        ListarPassagens();
    } else {
        MenuInicial();
    }
}

static void CadastrarPassagem() {
    Console.WriteLine($" === CADASTRO DE PASSAGEM === \n");
    Console.Write($"Digite o nome do passageiro: ");
    string nome = Console.ReadLine()!;

    Console.Write($"Digite o local de origem do voo: ");
    string origem = Console.ReadLine()!;

    Console.Write($"Digite o local de destino do voo: ");
    string destino = Console.ReadLine()!;

    Console.Write($"Digite a data do voo [dd/mm/yyyy]: ");
    string data = Console.ReadLine()!;

    string[] passagem = new string[4] {nome, origem, destino, data};
    Globals.passagens.Add(passagem);
    
    Mensagem($"Passagem cadastrada com sucesso!", ConsoleColor.Green);
    MenuPassagens();
}

static void ListarPassagens() {
    if (Globals.passagens.Any()) {
        Console.WriteLine($" === LISTA DE PASSAGENS === \n");
        int i = 0;
        foreach (string[] passagem in Globals.passagens) {
            i++;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{i}º Passagem:");
            Console.ResetColor();
            Console.WriteLine($"Nome do passageiro: {passagem[0]}");
            Console.WriteLine($"{passagem[1]}  {(char)(0x2708)}  {passagem[2]}");
            Console.WriteLine($"Data do voo: {passagem[3]} \n");
        }
    } else {
        Mensagem($"Nenhuma passagem foi registrada!");
        MenuPassagens();
    }
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"Lista de passagens completa. Aperte ENTER para continuar...");
    Console.ResetColor();
    Console.ReadLine();
    MenuPassagens();
}

// Programa Principal
MenuInicial();
MenuPassagens();

// Classe para variáveis globais (confesso que não encontrei outra maneira de fazer isso funcionar se não com essa classe)
public static class Globals {
    public static List<List<string>> dados = new List<List<string>>();
    public static List<string[]> passagens = new List<string[]>();
}
