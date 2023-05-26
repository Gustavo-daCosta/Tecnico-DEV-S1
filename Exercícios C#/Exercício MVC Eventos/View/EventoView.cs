using Exercício_MVC_Eventos.Controller;
using Exercício_MVC_Eventos.Model;

namespace Exercício_MVC_Eventos.View
{
    public class EventoView
    {
        public void Menu(EventoController controller) {
            menu:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" === SISTEMA DE EVENTOS ===");
            Console.ResetColor();
            Console.WriteLine(@$"Selecione uma opção:
            [1] - Cadastrar evento
            [2] - Listar eventos

            [0] - Sair do programa
            ");
            Console.Write($"Digite a opção desejada: ");
            int opcao = int.Parse(Console.ReadLine()!);

            if (opcao < 0 || opcao > 2) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Opção inválida digitada! Tente novamente.");
                Console.ResetColor();
                Console.Write($"Aperte ENTER para continuar...");
                Console.ReadLine();
                goto menu;
            }

            switch (opcao) {
                case 1:
                    controller.Cadastrar();
                    goto menu;
                case 2:
                    controller.Listar();
                    Funcionalidades.Mensagem($"\nFim da lista de eventos", ConsoleColor.Green);
                    goto menu;
                default:
                    Console.WriteLine($"Saindo do programa...");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Environment.Exit(1);
                    break;
            }
        }

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
                Funcionalidades.Mensagem($"Um evento com este nome já existe! Tente novamente.");
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