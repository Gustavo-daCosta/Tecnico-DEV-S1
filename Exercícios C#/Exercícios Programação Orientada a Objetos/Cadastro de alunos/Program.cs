// Instânciação da classe Aluno
using Cadastro_de_alunos;

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
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($" === SISTEMA DE CADASTRO DE ALUNOS === ");
    Console.ResetColor();
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
    Aluno aluno = new Aluno();

    Console.WriteLine(" === CADASTRO DE ALUNO === ");

    Console.Write($"Nome do aluno: ");
    aluno.nome = Console.ReadLine()!;

    Console.Write($"Curso do aluno: ");
    aluno.curso = Console.ReadLine()!;

    Console.Write($"Idade do aluno: ");
    aluno.idade = int.Parse(Console.ReadLine()!);

    Console.Write($"RG do aluno: ");
    aluno.rg = Console.ReadLine()!;

    Console.Write($"Média final do aluno: ");
    aluno.media = float.Parse(Console.ReadLine()!);

    Console.Write($"Mensalidade do aluno: ");
    aluno.mensalidade = float.Parse(Console.ReadLine()!);

    bolsa:
    Console.Write($"O aluno possui bolsa de estudos? [S/N] ");
    char temBolsa = char.Parse(Console.ReadLine()!.ToUpper());

    if (temBolsa == 'S' || temBolsa == 'N') {
        aluno.temBolsa = temBolsa == 'S';
    } else {
        Mensagem("Valor inválido digitado! Tente novamente.", ConsoleColor.Red);
        goto bolsa;
    }

    Globals.alunos.Add(aluno);
    Mensagem($"Aluno cadastrado com sucesso!", ConsoleColor.Green);

    dadosAluno:
    Console.WriteLine($"\n === DADOS DO ALUNO === ");
    Console.WriteLine(@$"
    [1] - Ver a média do aluno
    [2] - Ver o valor da mensalidade do aluno

    [0] - Voltar ao menu principal
    ");
    Console.Write($"Digite a opção desejada: ");
    int opcao = int.Parse(Console.ReadLine()!);
    
    if (opcao >= 0 && opcao <= 2) {
        if (opcao == 1) {
            Console.WriteLine($"Média do Aluno: {aluno.VerMediaFinal()}");
        } else if (opcao == 2) {
            Console.WriteLine($"Mensalidade do aluno: {aluno.VerMensalidade()}");
        }
    } else {
        Mensagem("Opção inválida digitada! Tente novamente.", ConsoleColor.Red);
        goto dadosAluno;
    }
}

static void VerAlunosCadastrados() {
    if (Globals.alunos.Any()) {
        int i = 0;
        foreach (Aluno aluno in Globals.alunos) {
            i++;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" === {i}º Aluno === ");
            Console.ResetColor();
            Console.WriteLine($"Nome: {aluno.nome}");
            Console.WriteLine($"Curso: {aluno.curso}");
            Console.WriteLine($"Idade: {aluno.idade} anos");
            Console.WriteLine($"RG: {aluno.rg}");
            Console.WriteLine($"Média final: {Math.Round(aluno.VerMediaFinal(), 2)}");
            Console.WriteLine($"Mensalidade: R${aluno.VerMensalidade()}");
            Console.Write($"Possui bolsa? ");
            Console.WriteLine(aluno.temBolsa ? "Sim \n" : "Não \n");
        }
        Mensagem("Fim da listagem de alunos!", ConsoleColor.Green);
    } else {
        Mensagem("Até o momento nenhum aluno foi registrado.", ConsoleColor.Blue);
    }
}

// Programa principal
int opcao = 0;

do {
    opcao = Menu();

    if (opcao == 1) {
        Console.Clear();
        CadastrarAluno();
    } else if (opcao == 2) {
        Console.Clear();
        VerAlunosCadastrados();
    } else {
        Mensagem("Saindo do programa...", ConsoleColor.Blue);
    }
} while (opcao != 0);

public class Globals {
    public static List<Aluno> alunos = new List<Aluno>();
}
