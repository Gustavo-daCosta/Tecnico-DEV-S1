// COM ARRAY

// array de strings com capacidade para armazenar 3 carros
string[] carros = new string[3];

for (int i = 0; i < 3; i++) {
    Console.Write($"Digite o nome do {i + 1}º carro: ");
    carros[i] = Console.ReadLine()!;
}

foreach (string carro in carros) {
    int index = Array.FindIndex(carros, x => x.Contains(carro));
    Console.WriteLine($"Nome do carro: {carro}  / Posição do carro: {index}");
}
