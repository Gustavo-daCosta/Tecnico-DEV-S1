// Faça um programa que leia três números e mostre o maior e o menor deles.

Console.Write($"Digite o 1º número: ");
int numero1 = int.Parse(Console.ReadLine()!);

Console.Write($"Digite o 2º número: ");
int numero2 = int.Parse(Console.ReadLine()!);

Console.Write($"Digite o 3º número: ");
int numero3 = int.Parse(Console.ReadLine()!);

int maiorNumero = new int[] { numero1, numero2, numero3 }.Max();
int menorNumero = new int[] { numero1, numero2, numero3 }.Min();

Console.WriteLine(@$"
Números: {numero1}, {numero2}, {numero3}
Maior número: {maiorNumero}
Menor número: {menorNumero}
");
