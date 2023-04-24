// Criando instância da classe Calculadora
using Projeto_Calculadora;

Calculadora calculadora = new Calculadora();

// MÉTODOS para funcionalidades
static void Mensagem(string mensagem, ConsoleColor cor) {
    Console.ForegroundColor = cor;
    Console.WriteLine(mensagem);
    Console.ResetColor();
    Console.WriteLine($"Aperte ENTER para continuar...");
    Console.Clear();
}

static int Menu() {
    menu:
    Console.Clear();
    Console.WriteLine($" === CALCULADORA === ");
    Console.WriteLine($"---------------------");
    Console.WriteLine(@$"Selecione a operação do seu cálculo:
    
    [1] (+) Adição
    [2] (-) Subtração
    [3] (*) Multiplicação
    [4] (/) Divisão
    [5] (**) Potenciação
    [6] (%) Porcentagem

    [0] - Sair
    ");
    Console.Write($"Digite a opção desejada: ");
    int opcao = int.Parse(Console.ReadLine()!);

    if (opcao < 0 || opcao > 5) {
        Mensagem($"Opção inválida digitada! Tente novamente.", ConsoleColor.Red);
        goto menu;
    }
    return opcao;
}

int opcao = 1;
while (opcao != 0) {
    opcao = Menu();

    // tem que resolver os problemas de retorno, tem muita coisa errada aqui

    switch (opcao) {
        case 1:
            calculadora.Adicao();
            break;
        case 2:
            calculadora.Subtracao();
            break;
        case 3:
            calculadora.Multiplicacao();
            break;
        case 4:
            calculadora.Divisao();
            break;
        case 5:
            calculadora.Potenciacao();
            break;
        case 16:
            calculadora.Porcentagem();
            break;
        default:
            ;
            break;
    }

}
