using Exercício_MVC_Eventos.Model;

namespace Exercício_MVC_Eventos.View
{
    public class EventoView
    {
        public void Listar(List<Evento> eventos) {
            int i = 0;
            foreach (Evento evento in eventos) {
                i++;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"\n{i}º Evento:");
                Console.ResetColor();
                Console.WriteLine($"Nome: {evento.Nome}");
                Console.WriteLine($"Descrição: {evento.Descricao}");
                Console.WriteLine($"Data: {evento.Data.ToShortDateString()}");
            }
        }

        public Evento Cadastrar(List<Evento> eventos) {
            evento:
            Console.Clear();
            Evento evento = new Evento();
            Console.WriteLine($" === CADASTRAR EVENTO ===");

            Console.Write($"Nome do evento: ");
            evento.Nome = Console.ReadLine()!;

            if (eventos.Exists(x => x.Nome == evento.Nome)) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Um evento com este nome já existe! Tente novamente.");
                Console.ResetColor();
                Console.Write($"Aperte ENTER para continuar...");
                Console.ReadLine();
                goto evento;
            }
            
            Console.Write($"Descrição do evento: ");
            evento.Descricao = Console.ReadLine();

            Console.Write($"Data do evento: ");
            evento.Data = DateTime.Parse(Console.ReadLine()!);

            return evento;
        }
    }
}