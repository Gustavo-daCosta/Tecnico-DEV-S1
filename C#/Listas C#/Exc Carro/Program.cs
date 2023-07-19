// Criar uma classe Carro
// - Marca
// - Cor
// Criar construtor vazio e completo
// Receber dados no console para adicionar 2 objetos em uma lista
// Exibir os dois objetos na lista de controle

using ClasseCarro;

List<Carro> carros = new List<Carro>();

for (int i = 0; i < 2; i++) {
    Console.Write($"Digite a marca do carro: ");
    string marca = Console.ReadLine()!;

    Console.Write($"Digite a cor do carro: ");
    string cor = Console.ReadLine()!;

    carros.Add(new Carro(marca, cor));
}

int count = 0;
foreach (Carro carro in carros) {
    count++;
    Console.WriteLine($"{count}º Carro");
    Console.WriteLine(String.Format("{0, -10} {1, 25}", $"Marca: {carro.Marca}", $"Cor: {carro.Cor}\n"));
}
