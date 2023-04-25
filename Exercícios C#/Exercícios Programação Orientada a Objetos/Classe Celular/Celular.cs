namespace Classe_Celular
{
    public class Celular
    {
        public string cor = "";
        public string modelo = "";
        public float tamanho;
        public bool estaLigado;

        public bool mudarEstadoCelular() {
            Console.WriteLine(!this.estaLigado ? "Ligando..." : "Desligando...");
            return !this.estaLigado;
        }

        public static class Contato {
            public static string nome = "";
            public static string telefone = "";
        }

        public class Globals {
            public List<Contato> contatos = new List<Contato>();
        }
    }
}