using POO_C_;

Personagem p1 = new Personagem();

Console.Write($"Informe o nome do personagem: ");
p1.nome = Console.ReadLine()!;

Console.Write($"Informe a idade do personagem: ");
p1.idade = int.Parse(Console.ReadLine()!);

Console.Write($"Informe a armadura do personagem: ");
p1.armadura = Console.ReadLine()!;

Console.Write($"Informe a IA do personagem: ");
p1.ia = Console.ReadLine()!;


Console.WriteLine(@$"
{p1.nome}
{p1.idade}
{p1.armadura}
{p1.ia}
");

p1.Atacar();
p1.Defender();
p1.RestaurarArmadura();
