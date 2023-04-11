// 

int[] numeros = new int[5];

for (int i = 0; i < 5; i++) {
    Console.Write($"Digite o valor do {i + 1}º número: ");
    numeros[i] = int.Parse(Console.ReadLine()!);
}

foreach (int numero in numeros) {
    Console.WriteLine($"O dobro de {numero} é {numero * 2}");
}
