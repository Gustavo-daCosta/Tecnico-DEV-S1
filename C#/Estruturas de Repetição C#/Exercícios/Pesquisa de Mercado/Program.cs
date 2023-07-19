// Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado
// produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
// A.O número de pessoas que responderam SIM.
// B.O número de pessoas que responderam NÃO;
// C.O número de mulheres que responderam SIM;
// D.A porcentagem de homens que responderam NÃO entre todos os homens analisados.

int numeroPessoasSim = 0;
int numeroMulheresSim = 0;
int numeroHomensNao = 0;

for (int i = 1; i <= 10; i++) {
    genero:
    Console.Write($"Digite o gênero da {i}º pessoa [M/F]: ");
    char genero = char.Parse(Console.ReadLine()!.ToUpper());

    Console.Write($"A {i}º pessoa gostou do produto [S/N]? ");
    char opiniaoProduto = char.Parse(Console.ReadLine()!.ToUpper());

    switch (opiniaoProduto) {
        case 'S':
            numeroPessoasSim++;
            if (genero == 'F') { numeroMulheresSim++; }
            break;
        case 'N':
            if (genero == 'M') { numeroHomensNao++; }
            break;
        default:
            Console.WriteLine("Valor inválido digitado.");
            goto genero;
    }
}

Console.WriteLine(@$"
Número de pessoas que responderam Sim: {numeroPessoasSim} pessoas
Número de pessoas que responderam Não: {10 - numeroPessoasSim} pessoas
Número de mulheres que responderam Sim: {numeroMulheresSim} mulheres
Número de homens que responderam Não: {numeroHomensNao} homens
");
