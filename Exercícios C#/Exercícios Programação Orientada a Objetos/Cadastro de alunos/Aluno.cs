namespace Cadastro_de_alunos
{
    public class Aluno
    {
        public string nome = "";
        public string curso = "";
        public int idade;
        public string rg = "";
        public float media;
        public float mensalidade;
        public bool temBolsa;

        public float VerMediaFinal() {
            return media;
        }

        public float VerMensalidade() {
            float valor = this.mensalidade;

            if (this.temBolsa == true && this.media >= 8) {
                valor -= this.mensalidade * 0.5F;
            } else if (this.temBolsa == true && this.media > 6) {
                valor -= this.mensalidade * 0.3F;
            }
            return valor;
        }
    }
}