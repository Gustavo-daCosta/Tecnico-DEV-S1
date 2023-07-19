using ClasseContato;

namespace InterfaceAgenda
{
    public interface IAgenda
    {
        public bool Adicionar(Contato contato);

        public void Listar();
    }
}