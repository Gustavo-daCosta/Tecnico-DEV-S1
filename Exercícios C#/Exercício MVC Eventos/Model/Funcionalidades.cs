namespace Exercício_MVC_Eventos.Model
{
    public class Funcionalidades
    {
        public static void Mensagem(string mensagem, ConsoleColor color = ConsoleColor.Red) {
            Console.ForegroundColor = color;
            Console.WriteLine(mensagem);
            Console.ResetColor();
            Console.WriteLine($"Aperte ENTER para continuar...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}