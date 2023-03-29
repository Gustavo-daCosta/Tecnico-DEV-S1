// Crie um programa para calcular o IMC de uma pessoa

Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.WriteLine(@$"
---------------------
         IMC         
---------------------
");
// Console.ResetColor();

// Entradas de dados
Console.BackgroundColor = ConsoleColor.DarkGreen;

Console.Write("Informe o nome do paciente: ");
string nome = Console.ReadLine();

Console.Write("Informe o peso do paciente: ");
float peso = float.Parse(Console.ReadLine());

Console.Write("Informe a altura do paciente: ");
float altura = float.Parse(Console.ReadLine()); 

// Processamento dos dados
float imc = peso / ((float)Math.Pow(altura, 2));

Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkCyan;

Console.WriteLine($"O IMC do {nome} é de {Math.Round(imc, 2)}");

Console.ResetColor();