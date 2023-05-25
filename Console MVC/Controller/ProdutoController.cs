using Console_MVC.Model;
using Console_MVC.View;

namespace Console_MVC.Controller
{
    public class ProdutoController
    {
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        // Método controlador para acessar a listagem de produtos
        public void ListarProdutos() {
            List<Produto> produtos = produto.Ler();

            produtoView.Listar(produtos);
        }

        public void CadastrarProdutos() {
            List<Produto> produtos = produto.Ler();

            Produto novoProduto = produtoView.Cadastrar(produtos);
            produto.Inserir(novoProduto);
        }
    }
}