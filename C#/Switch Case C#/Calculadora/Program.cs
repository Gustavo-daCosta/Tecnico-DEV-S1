// Calculadora

// Algoritmo

// 1. Informar a operação
// 2. Informar o primeiro número
// 3. Informar o segundo número
// 4. Processar os dados
// 5. Exibir os resultados

// Entrada
Console.WriteLine(@$"
/-------------------------\
| Programa de Calculadora |
|-------------------------|
|    Operações:           |
|                         |
|    (+) Soma             |
|    (-) Subtração        |
|    (*) Multiplicação    |
|    (/) Divisão          |
|                         |
\-------------------------/
");
Console.Write($"Informe a operação: ");
char operacao = char.Parse(Console.ReadLine()!);

Console.Write($"Informe o primeiro número: ");
double num1 = double.Parse(Console.ReadLine()!);

Console.Write($"Informe o segundo número: ");
double num2 = double.Parse(Console.ReadLine()!);

// Processamento
double resultado = 0;

switch (operacao) {
    case '+':
        resultado = (num1 + num2);
        break;
    case '-':
        resultado = (num1 - num2);
        break;
    case '*':
        resultado = (num1 * num2);
        break;
    case '/':
        resultado = (num1 / num2);
        break;
    default:
        Console.WriteLine($"Operador inválido!");
        return;
        break;
}

// Saída
Console.WriteLine($"O resultado da conta é igual a: {resultado}");
