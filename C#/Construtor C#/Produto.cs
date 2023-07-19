namespace Construtor
{
    public class Produto
    {
        public string? Codigo { get; set; }
        public string? Nome { get; set; }
        public float Preco { get; set; }

        // CONSTRUTORES:
        public Produto() {}
        public Produto(string codigo, string nome, float preco) {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }
    }
}

// O construtor é o método
