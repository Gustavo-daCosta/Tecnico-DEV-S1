namespace ClasseMoeda
{
    public class Moeda
    {
        public Moeda(string nome, string sigla, float valor, string codigoPais) {
            Nome = nome;
            Sigla = sigla;
            Valor = valor;
            CodigoPais = codigoPais;
        }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public float Valor { get; set; }
        public string CodigoPais { get; set; }
    }
}