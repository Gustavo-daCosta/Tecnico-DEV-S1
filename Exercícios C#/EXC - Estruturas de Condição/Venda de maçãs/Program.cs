//As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor total da compra.

Console.Write($"Digite a quantidade maçãs que você deseja comprar: ");
int quantidadeMacas = int.Parse(Console.ReadLine()!);
    
float valor = quantidadeMacas * (float)(quantidadeMacas >= 12 ? 0.25 : 0.3);

Console.WriteLine($"Valor total da compra: R${Math.Round(valor, 2)}");
