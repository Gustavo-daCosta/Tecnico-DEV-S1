string[] nomes = new string[10];

for (int i = 0; i < 10; i++) {
    Console.Write($"Digite o nome da {i + 1}º pessoa: ");
    nomes[i] = Console.ReadLine()!.ToLower();
}

Console.Write($"Digite o nome da pessoa que você deseja buscar: ");
string nome = Console.ReadLine()!.ToLower();

if (nomes.Contains(nome)) {
    Console.WriteLine($"O nome FOI encontrado no vetor");
} else {
    Console.WriteLine($"O nome NÃO FOI encontrado no vetor");
}
