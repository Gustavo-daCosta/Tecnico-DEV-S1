namespace ClasseFuncionalidades
{
    public class Funcionalidades
    {
        public static void Mensagem(string mensagem, ConsoleColor consoleColor = ConsoleColor.Red, bool limparConsole = true) {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(mensagem);
            Console.ResetColor();
            Console.Write($"Aperte ENTER para continuar...");
            Console.ReadLine();
            if (limparConsole) { Console.Clear(); }
        }
    }
}