// Instânciação da classe Aluno
using Cadastro_de_alunos;

Aluno aluno = new Aluno();

// Métodos de funcionalidades
static void Mensagem(string mensagem, ConsoleColor cor) {
    Console.ForegroundColor = cor;
    Console.WriteLine(mensagem);
    Console.ResetColor();
    Console.Write($"Aperte ENTER para continuar...");
    Console.ReadLine();
    Console.Clear();
}

// Métodos principais
static int Menu() {
    menu:
    Console.WriteLine($" === SISTEMA DE CADASTRO DE ALUNOS === ");
    Console.WriteLine(@$"
    [1] - Cadastrar aluno
    [2] - Ver alunos cadastrados

    [0] - Sair do sistema
    ");
    Console.Write($"Digite a opção desejada: ");
    int opcao = int.Parse(Console.ReadLine()!);

    if (opcao < 0 || opcao > 2) {
        Mensagem($"Opção inválida digitada! Tente novamente.", ConsoleColor.Red);
        goto menu;
    }

    return opcao;
}

static void CadastrarAluno() {
    Console.WriteLine(" === CADASTRO DE ALUNO === ");

    Console.WriteLine($"Nome do aluno: ");
    aluno.nome = Console.ReadLine()!;
}

// Programa principal
int opcao = Menu();

if (opcao == 1) {

}


// Classe para variáveis globais
public static class Globals {
    public static List<Aluno> alunos = new List<Aluno>();
}
