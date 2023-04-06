// 1. Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.

float nota = 0;

do {
    Console.Write($"Digite uma nota entre 0 e 10: ");
    nota = int.Parse(Console.ReadLine()!);

    if (nota < 0 || nota > 10) {
        Console.WriteLine($"A nota digitada é inválida.");
    }
} while (nota < 0 || nota > 10);

Console.WriteLine($"Nota registrada!");
