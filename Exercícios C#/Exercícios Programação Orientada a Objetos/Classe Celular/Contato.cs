using GlobalsVariables;

namespace Classe_Contato
{
    public class Contato
    {
        public string nome = "";
        public string telefone = "";

        public bool ListarContatos() {
            if (Globals.contatos.Any()) {
                int i = 0;
                foreach (Contato contato in Globals.contatos) {
                    i++;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"[{i}] - Contato {i}");
                    Console.ResetColor();
                    Console.WriteLine($"Nome: {contato.nome}");
                    Console.WriteLine($"Telefone: {contato.telefone} \n");
                }
                return true;
            } else {
                return false;
            }
        }
    }
}