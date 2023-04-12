// Escreva um programa que receba e imprima o nome e idade de 5 pessoas (mude a cor do resultado)
string[] nomes = new string[5];
int[] idades = new int[5];

for (int i = 0; i < 5; i++) {
    Console.Write($"Digite o nome da {i + 1}º pessoa: ");
    nomes[i] = Console.ReadLine()!;

    Console.Write($"Digite a idade da {i + 1}º pessoa: ");
    idades[i] = int.Parse(Console.ReadLine()!);
}

for (int i = 0; i < 5; i++) {
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine($"{i + 1}) Nome: {nomes[i]}");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"Idade: {idades[i]} anos");
}
