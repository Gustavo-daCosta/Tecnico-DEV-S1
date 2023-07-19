// Faça um programa que receba a idade, o peso e o sexo de 10 pessoas. Calcule e imprima:
// A.Total de Homens;      
// B.Total de Mulheres;      
// C.Média de idade dos Homens;      
// D.Média de idade das mulheres.

int totalHomens = 0;
int totalMulheres = 0;
float totalIdadeHomens = 0;
float totalIdadeMulheres = 0;

for (int i = 1; i <= 10; i++) {
    Console.Write($"Digita a idade da {i}º pessoa: ");
    int idade = int.Parse(Console.ReadLine()!);

    // Console.Write($"Digita o peso da {i}º pessoa: ");
    // float peso = float.Parse(Console.ReadLine()!);

    genero:
    Console.Write($"Digita o gênero da {i}º pessoa [M/F]: ");
    char genero = char.Parse(Console.ReadLine()!.ToUpper());

    switch (genero) {
        case 'M':
            totalHomens++;
            totalIdadeHomens += idade;
            break;
        case 'F':
            totalMulheres++;
            totalIdadeMulheres += idade;
            break;
        default:
            Console.WriteLine("Gênero inválido, tente novamente.");
            goto genero;
    }
}

Console.WriteLine(@$"
Total de homens: {totalHomens} homens
Total de mulheres: {totalMulheres} mulheres
Média de idade dos homens: {Math.Round(totalIdadeHomens / totalHomens, 1)} anos
Média de idade das mulheres: {Math.Round(totalIdadeMulheres / totalMulheres, 1)} anos
");
