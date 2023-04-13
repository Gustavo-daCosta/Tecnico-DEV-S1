using System.Linq;

string[] nomes = new string[2];

for (int i = 0; i < 2; i++) {
    Console.WriteLine($"Digite o nome da {i + 1}º pessoa: ");
    nomes[i] = Console.ReadLine()!.ToUpper();
}

Console.WriteLine($"Digite o nome da pessoa que você deseja buscar: ");
string nome = Console.ReadLine()!.ToUpper();

if (nomes.Contains(nome)) {
    Console.WriteLine($"O nome FOI encontrado no vetor");
} else {
    Console.WriteLine($"O nome NÃO FOI encontrado no vetor");
}
