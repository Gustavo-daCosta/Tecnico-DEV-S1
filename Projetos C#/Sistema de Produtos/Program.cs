// Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:

// Os produtos terão os seguintes atributos:
// string Nome
// float Preco
// bool Promocao (se está em promoção ou não)

// O sistema deverá ter as seguintes funcionalidades:
// CadastrarProduto
// ListarProdutos
// MostrarMenu

// + Sistema de cadastro e log-in completo e funcional

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

// MÉTODOS PRINCIPAIS
static void MenuInicial() {
    int opcao = Menu(@$" === Entre na sua conta para registrar os produtos! === 

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
                MenuProdutos();
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

static void MenuProdutos() {
    Console.Clear();
    int opcao = Menu(@$" === CONTROLE DE PRODUTOS DO MERCADO === 

    [1] Cadastrar produto
    [2] Listar produtos

    [0] Sair da conta
    ");
    
    if (opcao == 1) {
        CadastrarProduto();
    } else if (opcao == 2) {
        ListarProdutos();
    } else {
        MenuInicial();
    }
}

static void CadastrarProduto() {
    Console.WriteLine($" === CADASTRO DE PRODUTOS === \n");
    Console.Write($"Digite o nome do produto: ");
    string nome = Console.ReadLine()!;

    Console.Write($"Digite o preço do produto: R$");
    float preco = float.Parse(Console.ReadLine()!);

    promocao:
    Console.Write($"O produto está em promoção [S/N]? ");
    char estaEmPromocao = char.Parse(Console.ReadLine()!.ToUpper());

    bool promocao;
    if (estaEmPromocao == 'S' || estaEmPromocao == 'N') {
        promocao = estaEmPromocao == 'S' ? true : false;
    } else {
        Console.WriteLine($"Valor digitado inválido! Tente novamente.");
        goto promocao;
    }

    // Tipo dynamic permite a entrada de qualquer outro tipo
    dynamic[] produto = new dynamic[3] {nome, preco, promocao};
    Globals.produtos.Add(produto);
    
    Mensagem($"Produto cadastrado com sucesso!", ConsoleColor.Green);
    MenuProdutos();
}

static void ListarProdutos() {
    if (Globals.produtos.Any()) {
        Console.WriteLine($" === LISTA DE PRODUTOS === \n");
        int i = 0;
        foreach (dynamic[] produto in Globals.produtos) {
            i++;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{i}º Produto:");
            Console.ResetColor();
            Console.WriteLine($"Nome do produto: {produto[0]}");
            Console.WriteLine($"Preço do produto: R${produto[1]}");
            Console.Write($"O produto está em promoção? ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(produto[2] ? "Sim \n": "Não \n");
            Console.ResetColor();
        }
    } else {
        Mensagem($"Nenhum produto foi registrado!");
        MenuProdutos();
    }
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"Lista de produtos completa. Aperte ENTER para continuar...", ConsoleColor.Green);
    Console.ResetColor();
    Console.ReadLine();
    MenuProdutos();
}

// Programa Principal
// MenuInicial();
MenuProdutos();

// Classe para variáveis globais
public static class Globals {
    public static List<List<string>> dados = new List<List<string>>();
    public static List<dynamic[]> produtos = new List<dynamic[]>();
}
