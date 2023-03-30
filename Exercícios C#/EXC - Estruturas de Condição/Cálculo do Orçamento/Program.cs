// Faça um programa que o usuário informe o salário recebido e o total gasto. Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto não ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.

Console.Write($"Informe o salário: R$");
float salario = float.Parse(Console.ReadLine()!);

Console.Write($"Informe o valor dos gastos: R$");
float gastos = float.Parse(Console.ReadLine()!);

if (salario >= gastos) {
    Console.WriteLine($"Os gastos estão dentro do orçamento.");
} else {
    Console.WriteLine($"O orçamento foi estourado.");
}
