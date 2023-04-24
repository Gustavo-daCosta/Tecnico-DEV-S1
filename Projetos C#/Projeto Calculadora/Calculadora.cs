namespace Projeto_Calculadora
{
    public class Calculadora
    {
        public double n1;
        public double n2;

        public double Adicao() {
            return n1 + n2;
        }

        public double Subtracao() {
            return n1 - n2;
        }

        public double Multiplicacao() {
            return n1 * n2;
        }

        public double Divisao() {
            return n1 / n2;
        }

        public double Potenciacao() {
            return Math.Pow(n1, n2);
        }

        public double Porcentagem() {
            return (n1 / 100) * n2;
        }
    }
}