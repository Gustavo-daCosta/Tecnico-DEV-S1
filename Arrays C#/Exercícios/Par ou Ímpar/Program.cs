int[] numeros = new int[6];

for (int i = 0; i < 6; i++) {
    Console.Write($"Digite o {i}º valor: ");
    numeros[i] = int.Parse(Console.ReadLine()!);
}

int quantidadePares = 0;

foreach (int numero in numeros) {
    quantidadePares += numero % 2 == 0 ? 1 : 0;
    // ((numero % 2) == 0) ? (quantidadePares += 1) : (quantidadeImpares += 1);
}

Console.WriteLine(@$"
Quantidade de valores pares: {quantidadePares}
Quantidade de valores ímpares: {6 - quantidadePares}
");
