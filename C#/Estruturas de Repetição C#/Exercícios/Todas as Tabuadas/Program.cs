// Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.

for (int t = 1; t <= 10; t++) {
    Console.WriteLine($"Tabuada do {t}");
    for (int i = 1; i <= 10; i++) {
        Console.WriteLine($"{i} * {t} = {i * t}");
    }
}
