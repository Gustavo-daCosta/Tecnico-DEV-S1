using System.Globalization;
using ClasseMoeda;

namespace CambioMoedas
{
    public static class Cambio
    {
        public static Moeda Real { get; set; } = new Moeda("Real Brasileiro", "BRL", 4.99F, "pt-BR");
        public static Moeda Euro { get; set; } = new Moeda("Euro", "EUR", 0.91F, "en-FR");
        public static Moeda IeneJapones { get; set; } = new Moeda("Iene Japonês", "JPY", 135.15F, "ja-JP");
        public static Moeda DolarCanadense { get; set; } = new Moeda("Dólar Canadense", "CAD", 1.34F, "en-CA");
        public static Moeda DolarAustraliano { get; set; } = new Moeda("Dólar Australiano", "AUD", 1.48F, "en-AU");
        public static Moeda PesoArgentino { get; set; } = new Moeda("Peso Argentino", "ARS", 228.11F, "es-AR");
        public static Moeda LibraEsterlina { get; set; } = new Moeda("Libra Esterlina", "GBP", 0.79F, "en-GB");

        public static List<Moeda> Moedas { get; set; } = new List<Moeda>() {
            Real, Euro, IeneJapones, DolarCanadense, DolarAustraliano, PesoArgentino, LibraEsterlina
        };

        public static float MoedaToMoeda(float moedaOrigem, float moedaDestino) => moedaOrigem / moedaDestino;

        public static void ListarMoedas() {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" === LISTA DE MOEDAS ===");
            Console.ResetColor();
            foreach (Moeda moeda in Moedas) {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Moeda: {moeda.Nome}");
                Console.ResetColor();
                Console.WriteLine(String.Format("{0, -30} {1, -10}", $"Câmbio de troca: {moeda.Valor.ToString("C2", CultureInfo.CreateSpecificCulture(moeda.CodigoPais))}", $"Sigla: {moeda.Sigla}"));
            }
        }
    }
}

// .ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))