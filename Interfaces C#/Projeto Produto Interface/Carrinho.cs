using ClasseProduto;
using InterfaceCarrinho;

namespace ClasseCarrinho
{
    public class Carrinho : ICarrinho
    {
        public float Valor { get; set; }

        // Criar uma lista para manipular os nossos objetos
        List<Produto> carrinho = new List<Produto>();

        public void Adicionar(Produto produto) => carrinho.Add(produto);

        public void Listar() {
            if (carrinho.Any()) {
                foreach (Produto produto in carrinho) {
                    Console.WriteLine(@$"
    Nome: {produto.Nome}
    Preço: {produto.Preco:C}
    Código: {produto.Codigo}
                    ");
                }
            } else {
                Console.WriteLine($"O carrinho está vázio!");
            }
        }

        public void Atualizar(int codigo, Produto novoProduto) {
            carrinho.Find(x => x.Codigo == codigo)!.Nome = novoProduto.Nome;
            carrinho.Find(x => x.Codigo == codigo)!.Preco = novoProduto.Preco;
        }

        public void Remover(Produto produto) {
            carrinho.Remove(produto);
        }

        public void TotalCarrinho() {
            Valor = 0;
            if (carrinho.Any()) {
                foreach (Produto produto in carrinho) {
                    Valor += produto.Preco;
                }
                Console.WriteLine($"O total do seu carrinho é: {Valor:C}");
            } else {
                Console.WriteLine($"O carrinho está vázio!");
            }
        }
    }
}