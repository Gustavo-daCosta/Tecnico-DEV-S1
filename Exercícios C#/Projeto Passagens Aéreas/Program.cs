// MOSTRAR MENU
// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.
// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:
// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair

// MOSTRAR MENU
// CADASTRAR / LOGAR USUARIO
// CASO CADASTRO PEÇA USUARIO E SENHA NOVOS
// CASO LOGAR PEÇA USUARIO E SENHA PRÉ CADASTRADOS
// ENTRAR NO SISTEMA DE PASSAGENS

// Variáveis globais
Array[] dados = new Array[2];

// MÉTODOS PARA FUNCIONALIDADES
static void MensagemDeErro(string mensagem) {
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(mensagem);
    Console.ResetColor();
    Console.Write($"Pressione ENTER para continuar...");
    Console.ReadLine();
    Console.Clear();
}

static void MenuInicial(Array[] dados) {
    menu:
    Console.WriteLine($"Entre na sua conta para registrar sua passagem!");
    Console.WriteLine(@$"
    - Você deseja fazer login ou cadastrar uma nova conta?
    [1] Fazer Log-in
    [2] Cadastrar uma nova conta

    [0] Sair
    ");
    Console.Write($"Selecione uma opção: ");
    int opcao = int.Parse(Console.ReadLine()!);

    if (opcao < 0 || opcao > 2) {
        MensagemDeErro("Opção inválida digitada! Tente novamente.");
        goto menu;
    }

    if (opcao == 0) {
        Environment.Exit(1);
    } else {
        MenuCadastroLogin(opcao, dados);
    }
}

static void MenuCadastroLogin(int opcao, Array[] dados) {
    Console.Clear();
    Console.WriteLine(opcao == 1 ? "Faça log-in na sua conta!" : "Cadastre uma nova conta!");

    usuario:
    Console.Write($"Digite o seu usuário: ");
    string usuario = Console.ReadLine()!;

    if (usuario.Length < 2 || usuario.Length > 32) {
        MensagemDeErro($"Nome de usuário inválido, digite um usuáio que tenha entre 2 e 32 caracteres");
        goto usuario;
    }

    senha:
    Console.Write($"Digite a sua senha (mínimo 6 caracteres): ");
    string senha = Console.ReadLine()!;

    if (senha.ToString().Length < 6 || senha.ToString().Length > 16) {
        MensagemDeErro($"Senha inválida, digite uma senha que tenha entre 6 e 16 caracteres");
        goto senha;
    }
    Console.Clear();
    string[] conta = {usuario, senha};

    if (opcao == 1) {
        VerificarConta(conta);
    } else {
        dados.Append(conta);
        MenuInicial(dados);
    }
}

static void VerificarConta(Array conta) {
    
}

Array[] passagens = new Array[5];

// bool desejaContinuar = true;
// while (desejaContinuar) {
    MenuInicial(dados);
// }
