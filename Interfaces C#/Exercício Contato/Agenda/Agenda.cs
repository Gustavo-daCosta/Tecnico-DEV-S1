using ClasseContato;
using InterfaceAgenda;

namespace ClasseAgenda
{
    public class Agenda : IAgenda
    {
        public List<Contato> Contatos { get; set; } = new List<Contato>();

        public bool Adicionar(Contato contato) {
            if (Contatos.Exists(contato))
            Contatos.Add(contato);
        }

        public void Listar() {
            foreach (Contato contato in Contatos) {
                Console.WriteLine($"");
            }
        }
    }
}