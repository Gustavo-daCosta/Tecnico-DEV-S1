using ClasseContato;
using InterfaceAgenda;

namespace ClasseAgenda
{
    public class Agenda : IAgenda
    {
        public List<Contato> Contatos { get; set; } = new List<Contato>();

        public bool Adicionar(Contato contato) {
            if (Contatos.Contains(contato)) {
                return false;
            } else {
                Contatos.Add(contato);
                return true;
            }
        }

        public void Listar() {
            int i = 0;
            foreach (Contato contato in Contatos) {
                i++;
                Console.WriteLine($"{i}º Contato");
                Console.WriteLine($"Nome: {contato.Nome}");
                Console.WriteLine($"Telefone: {contato.Telefone}");
                Console.WriteLine($"Email: {contato.Email}");
            }
        }
    }
}