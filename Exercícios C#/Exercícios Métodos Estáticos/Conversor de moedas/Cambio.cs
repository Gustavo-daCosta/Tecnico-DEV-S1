using ClasseMoeda;

namespace CambioMoedas
{
    public static class Cambio
    {
        public static List<dynamic> Real { get; set; } = new List<dynamic> {"Real Brasileiro", "BRL", 4.99F, "pt-BR"};
        public static List<dynamic> Euro { get; set; } = new List<dynamic> {"Euro", "EUR", 0.91F, "es-ES"};
        public static List<dynamic> IeneJapones { get; set; } = new List<dynamic> {"Iene Japonês", "JPY", 135.15F, "ja-JP"};
        public static List<dynamic> DolarCanadense { get; set; } = new List<dynamic> {"Dólar Canadense", "CAD", 1.34F, "en-CA"};
        public static List<dynamic> DolarAustraliano { get; set; } = new List<dynamic> {"Dólar Australiano", "AUD", 1.48F, "en-AU"};
        public static List<dynamic> PesoArgentino { get; set; } = new List<dynamic> {"Peso Argentino", "ARS", 228.11F, "es-AR"};
        public static List<dynamic> LibraEsterlina { get; set; } = new List<dynamic> {"Libra Esterlina", "GBP", 0.79F, "en-GB"};

        public static List<List<dynamic>> Moedas { get; set; } = new List<List<dynamic>>() {
            Real, Euro, IeneJapones, DolarCanadense, DolarAustraliano, PesoArgentino, LibraEsterlina
        };

        public static float MoedaToMoeda(float moedaOrigem, float moedaDestino) => moedaOrigem / moedaDestino;

        public static void ListarMoedas() {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" === LISTA DE MOEDAS ===\n");
            Console.ResetColor();
            Console.WriteLine($"NOME | SIGLA | VALOR | CÓD. PAÍS");
            foreach (List<dynamic> moeda in Moedas) {
                Console.WriteLine(String.Format("{0, -10} | {1, -10}, {2, 5}, {3, 10}", moeda[0]));
            }
        }
    }
}

// .ToString("C2", CultureInfo.CreateSpecificCulture("en-US"))