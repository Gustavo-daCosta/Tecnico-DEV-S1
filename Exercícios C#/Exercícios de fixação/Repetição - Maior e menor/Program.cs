float[] numeros = new float[10];

for (int i = 0; i < 10; i++) {
    Console.Write($"Digite o {i + 1}º valor: ");
    numeros[i] = float.Parse(Console.ReadLine()!);
}

Console.WriteLine($"Menor valor lido: {numeros.Min()}");
Console.WriteLine($"Maior valor lido: {numeros.Max()}");
