using Console_MVC.Model;

namespace Console_MVC.View
{
    public class ProdutoView
    {
        // Método para exibir os dados da lista no console
        public void Listar(List<Produto> produtos) {
            foreach (Produto produto in produtos) {
                Console.WriteLine($"\nCódigo: {produto.Codigo}");
                Console.WriteLine($"Nome: {produto.Nome}");
                Console.WriteLine($"Preço: {produto.Preco:c}");
            }
        }

        public Produto Cadastrar(List<Produto> produtos) {
            Console.WriteLine($" === CADASTRAR PRODUTO ===");
            Produto novoProduto = new Produto();

            novoProduto.Codigo = GerarCodigo(produtos);

            Console.Write($"Informe o nome: ");
            novoProduto.Nome = Console.ReadLine()!;

            Console.Write($"Informe o preço: R$");
            novoProduto.Preco = float.Parse(Console.ReadLine()!);

            return novoProduto;
        }

        private int GerarCodigo(List<Produto> produtos) {
            Random random = new Random();
            int codigo;
            
            codigo:
            codigo = random.Next(1000, 9999);

            if (produtos.Exists(x => x.Codigo == codigo)) {
                goto codigo;
            }
            return codigo;
        }
    }
}