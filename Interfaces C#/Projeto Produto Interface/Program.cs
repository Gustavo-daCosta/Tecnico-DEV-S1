using ClasseProduto;
using ClasseCarrinho;

// Instância do objeto Carrinho
Carrinho carrinho = new Carrinho();

// Instância do objeto Produto
Produto prod1 = new Produto(1, "GTA 5", 52.90F);
Produto prod2 = new Produto(2, "Detroit Become Human", 120.50F);
Produto prod3 = new Produto(3, "Forza", 100F);

carrinho.Adicionar(prod1);
carrinho.Adicionar(prod2);
carrinho.Adicionar(prod3);

carrinho.Listar();

carrinho.TotalCarrinho();

carrinho.Remover(prod2);
carrinho.Remover(prod3);

Console.WriteLine($"Após a remoção de um item");
carrinho.Listar();

carrinho.TotalCarrinho();

Produto novoProduto = new Produto();
novoProduto.Nome = "Fifa 2023";
novoProduto.Preco = 300F;

carrinho.Atualizar(1, novoProduto);

carrinho.Listar();

carrinho.TotalCarrinho();
