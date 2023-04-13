// LER:  a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade &lt;= 5 o desconto será de 2%
// - Se quantidade &gt; 5 e quantidade &lt;=10 o desconto será de 3%
// - Se quantidade &gt; 10 o desconto será de 5%

using System.Globalization;

Console.WriteLine($"=== MERCADO ===");
Console.Write($"Digite o nome do produto: ");
string nome = Console.ReadLine()!;

Console.Write($"Digite a quantidade adquirida: ");
int quantidade = int.Parse(Console.ReadLine()!);

Console.Write($"Digite o preço unitário: R$");
float precoUnitario = float.Parse(Console.ReadLine()!);

float preco = quantidade * precoUnitario;
int desconto = 0;

if (quantidade <= 5) {
    preco -= preco * 0.02F;
    desconto = 2;
} else if (quantidade <= 10) {
    preco -= preco * 0.03F;
    desconto = 3;
} else {
    preco -= preco * 0.05F;
    desconto = 5;
}

Console.WriteLine(@$"
Nome do produto: {nome}
Quantidade adquirida: {quantidade} unidades
Preço unitário: {precoUnitario.ToString("C", new CultureInfo("pt-BR"))}

Desconto aplicado: {desconto}%
Valor a se pagar: {preco.ToString("C", new CultureInfo("pt-BR"))}
");
