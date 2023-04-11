// SEM ARRAY
string carro1;
string carro2;
string carro3;

Console.WriteLine($"Digite o nome do carro: ");
carro1 = Console.ReadLine()!;

Console.WriteLine($"Digite o nome do carro: ");
carro2 = Console.ReadLine()!;

Console.WriteLine($"Digite o nome do carro: ");
carro3 = Console.ReadLine()!;

Console.WriteLine(@$"
{carro1}
{carro2}
{carro3}
");
