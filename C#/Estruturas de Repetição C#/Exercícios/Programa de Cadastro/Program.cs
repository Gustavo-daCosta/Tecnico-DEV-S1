// Faça um programa que leia e valide as seguintes informações
// Nome: Diferente de vazio
// Idade: entre 0 e 100 anos
// Salário: maior que zero
// Estado Civil: solteiro / casado / viúvo / divorciado

string nome = "";
int idade = 0;
float salario = 0;
int opcaoEstadoCivil = 0;
string estadoCivil = "";

do {
    Console.Write($"Digite seu nome: ");
    nome = Console.ReadLine()!;
} while (string.IsNullOrEmpty(nome));

do {
    Console.Write($"Digite sua idade: ");
    idade = int.Parse(Console.ReadLine()!);
} while (idade < 0 || idade > 100);

do {
    Console.Write($"Digite seu salário: ");
    salario = float.Parse(Console.ReadLine()!);
} while (salario <= 0);

do {
    Console.WriteLine(@$"
Estado Civil
1 - Solteiro(a)        2 - Casado(a)
3 - Viúvo(a)           4 - Divorciado(a)");
    Console.Write($"Selecione o número da opção: ");
    opcaoEstadoCivil = int.Parse(Console.ReadLine()!);
    
    switch (opcaoEstadoCivil) {
        case 1:
            estadoCivil = "Solteiro";
            break;
        case 2:
            estadoCivil = "Casado";
            break;
        case 3:
            estadoCivil = "Viúvo";
            break;
        case 4:
            estadoCivil = "Divorciado";
            break;
        default:
            Console.WriteLine("Valor inválido!");
            break;
    }

} while (opcaoEstadoCivil != 1 && opcaoEstadoCivil != 2 && opcaoEstadoCivil != 3 && opcaoEstadoCivil != 4);

Console.WriteLine(@$"
Cadastro do usuário:
Nome: {nome}
Idade: {idade} anos
Salário: R${salario:F2}
Estado Civil: {estadoCivil}
");
