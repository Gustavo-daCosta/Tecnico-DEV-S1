using Console_MVC.Model;

namespace Console_MVC.View
{
    public class ProdutoView
    {
        // Método para exibir os dados da lista no console
        public void Listar(List<Produto> produtos) {
            foreach (Produto produto in produtos) {
                Console.WriteLine($"Código: {produto.Codigo}");
                Console.WriteLine($"Nome: {produto.Nome}");
                Console.WriteLine($"Preço: {produto.Preco:c}");
            }
        }
    }
}