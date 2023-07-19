using ClasseProduto;

namespace InterfaceCarrinho
{
    public interface ICarrinho {
        // Regras do "contrato":
        // Métodos que deverão ser apenas declarados (ou seja, não possuem corpo)

        // Padrão de chamada de métodos:
        // tipo Nome(parâmetros)

        // CRUD: Create, Read, Update, Delete

        // Create
        void Adicionar(Produto produto);

        // Read
        void Listar();

        // Update
        void Atualizar(int codigo, Produto produto);

        // Delete
        void Remover (Produto produto);
    }
}