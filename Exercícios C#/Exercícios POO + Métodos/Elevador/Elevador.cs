using ClasseFuncionalidades;

namespace ClasseElevador
{
    public class Elevador
    {
        public int AndarAtual { get; set; } = 0;
        public int NumeroDeAndares { get; set; }
        public int CapacidadeDePessoas { get; set; }
        public int QuantidadePessoas { get; set; } = 0;

        public void Inicializar() {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" === INICIALIZAR ELEVADOR ===\n");
            Console.ResetColor();

            capacidade:
            Console.Write($"Digite a capacidade de pessoas do elevador: ");
            this.CapacidadeDePessoas = int.Parse(Console.ReadLine()!);

            if (this.CapacidadeDePessoas <= 0) {
                Console.WriteLine($"Valor digitado inválido! Digite um valor maior que zero.");
                goto capacidade;
            }

            andares:
            Console.Write("Digite o número total de andares do prédio: ");
            this.NumeroDeAndares = int.Parse(Console.ReadLine()!);

            if (this.NumeroDeAndares <= 0) {
                Console.WriteLine($"Valor digitado inválido! Digite um valor maior que zero.");
                goto andares;
            }
        }

        public void Entrar() {
            if (this.QuantidadePessoas < this.CapacidadeDePessoas) {
                this.QuantidadePessoas++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Uma pessoa entrou no elevador!");
                Console.ResetColor();
                Console.WriteLine($"Total de pessoas no elevador: {this.QuantidadePessoas} pessoas");
            } else {
                Funcionalidades.Mensagem($"O elevador está lotado! Remova uma pessoa antes de deixar outra entrar.");
            }
            Console.Write($"Aperte ENTER para continuar...");
            Console.ReadLine();
        }

        public void Sair() {
            if (this.QuantidadePessoas > 0) {
                this.QuantidadePessoas--;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Uma pessoa saiu do elevador!");
                Console.ResetColor();
                Console.WriteLine($"Total de pessoas no elevador: {this.QuantidadePessoas} pessoas");
            } else {
                Funcionalidades.Mensagem($"O elevador está vazio! Adicione uma pessoa antes de deixar alguém sair.");
            }
            Console.Write($"Aperte ENTER para continuar...");
            Console.ReadLine();
        }

        public void Subir() {
            if (this.AndarAtual < this.NumeroDeAndares) {
                menuAndar:
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($" === SUBIR ELEVADOR ===");
                Console.ResetColor();
                Console.WriteLine($"\nPara qual andar você deseja ir?");
                for (int i = 0; i <= this.NumeroDeAndares; i++) {
                    if (i > this.AndarAtual && i == 0) {
                        Console.WriteLine($"    [{i}] Térreo");
                    } else if (i > this.AndarAtual) {
                        Console.WriteLine($"    [{i}] {i}º Andar");
                    }
                }
                Console.Write($"Digite a opção desejada: ");
                int andar = int.Parse(Console.ReadLine()!);

                if (andar <= this.AndarAtual || andar > this.NumeroDeAndares) {
                    Funcionalidades.Mensagem($"Valor inválido digitado! Tente novamente.");
                    goto menuAndar;
                }

                this.AndarAtual = andar;
                Funcionalidades.Mensagem($"O elevador subir para o andar {this.AndarAtual} com sucesso!", ConsoleColor.Green);
            } else {
                Funcionalidades.Mensagem($"O elevador no último andar! Só há como descer andares.");
            }
        }

        public void Descer() {
            if (this.AndarAtual > 0) {
                menuAndar:
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($" === DESCER ELEVADOR ===");
                Console.ResetColor();
                Console.WriteLine($"\nPara qual andar você deseja ir?");
                for (int i = this.AndarAtual; i >= 0; i--) {
                    if (i > this.AndarAtual && i == 0) {
                        Console.WriteLine($"    [{i}] Térreo");
                    } else if (i > this.AndarAtual) {
                        Console.WriteLine($"    [{i}] {i}º Andar");
                    }
                }
                Console.Write($"\nDigite a opção desejada: ");
                int andar = int.Parse(Console.ReadLine()!);

                if (andar <= this.AndarAtual || andar > this.NumeroDeAndares) {
                    Funcionalidades.Mensagem($"Valor inválido digitado! Tente novamente.");
                    goto menuAndar;
                }

                this.AndarAtual = andar;
                Funcionalidades.Mensagem($"O elevador desceu para o {this.AndarAtual}º andar com sucesso!", ConsoleColor.Green);
            } else {
                Funcionalidades.Mensagem($"Você está no térreo! Só há como subir andares.");
            }
        }
    }
}