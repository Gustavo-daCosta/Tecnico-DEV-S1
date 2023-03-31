//Escreva um programa que pergunte o dia, mês e ano do aniversário de uma pessoa e diga se a data é válida ou não. Caso não seja, diga o motivo. Suponha que todos os meses tem 31 dias e que estejamos no ano de 2013.

Console.Write($"Digite o dia do seu nascimento: ");
int dia = int.Parse(Console.ReadLine()!);

Console.Write($"Digite o mês do seu nascimento: ");
int mes = int.Parse(Console.ReadLine()!);

Console.Write($"Digite o ano do seu nascimento: ");
int ano = int.Parse(Console.ReadLine()!);

if ((dia >= 1 && dia <= 31) && (mes >= 1 && dia <= 12) && (ano >= 0 && ano <= 2013)) {
    Console.WriteLine($"Data de nascimento válida!");
} else {
    Console.WriteLine($"Data de nascimento inválida!");
}
