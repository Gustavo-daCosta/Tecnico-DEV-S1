using ClasseProduto;

Console.Write($"Digite o código do produto: ");
int codigo = int.Parse(Console.ReadLine()!);

Console.Write($"Digite o nome do produto: ");
string nome = Console.ReadLine()!;

Console.Write($"Digite o preço do produto: R$");
float preco = float.Parse(Console.ReadLine()!);

Produto produto = new Produto();

Produto produto1 = new Produto(codigo, nome, preco);

List<Produto> produtos = new List<Produto>();

produtos.Add(new Produto(2563, "Camiseta QuickSilver", 19.90F));
produtos.Add(new Produto(1025, "Tênis Naiki", 50F));

Console.WriteLine($"LISTA ANTIGA\n*********");
foreach (Produto item in produtos) {
    Console.WriteLine($"Código: {item.Codigo}, Nome: {item.Nome}, Preço: {item.Preco:C}, Index: {produtos.IndexOf(item)}");
}

Produto produtoBuscado = produtos.Find(x => x.Codigo == 2563)!;

int index = produtos.IndexOf(produtoBuscado);

produtoBuscado.Preco = 199.90F;

produtos.RemoveAt(index);

produtos.Insert(index, produtoBuscado);

Console.WriteLine($"LISTA NOVA\n*********");
foreach (Produto item in produtos) {
    Console.WriteLine($"Código: {item.Codigo}, Nome: {item.Nome}, Preço: {item.Preco:C}, Index: {produtos.IndexOf(item)}");
}
