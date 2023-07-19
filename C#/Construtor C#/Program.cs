using Construtor;

Produto produto = new Produto();

Console.Write($"Informe o código: ");
produto.Codigo = Console.ReadLine();

Console.Write($"Informe o nome: ");
produto.Nome = Console.ReadLine();

Console.Write($"Informe o preço: R$");
produto.Preco = float.Parse(Console.ReadLine()!);
