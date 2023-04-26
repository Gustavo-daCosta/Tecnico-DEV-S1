namespace Classe_Celular
{
    public class Celular
    {
        public string cor = "";
        public string modelo = "";
        public float tamanho;
        public bool estaLigado;

        public bool MudarEstadoCelular() {
            Console.WriteLine(!this.estaLigado ? "Ligando..." : "Desligando...");
            return !this.estaLigado;
        }

        public void FazerLigacao() {
            Console.WriteLine($"Ligando...");
        }

        public void EnviarMensagem() {
            Console.WriteLine("Enviando mensagem...");
        }

        public string VerEstadoCelular() {
            return this.estaLigado ? "Ligado" : "Desligado";
        }
    }
}