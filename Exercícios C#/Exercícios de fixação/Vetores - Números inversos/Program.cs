float[] valores = new float[10];

for (int i = 0; i < 10; i++) {
    Console.Write($"Digite o {i + 1}º valor: ");
    valores[i] = float.Parse(Console.ReadLine()!);
}

foreach (float valor in valores.Reverse()) {
    Console.Write($"{valor} ");
}
