// Crie um programa para calcular o IMC de uma pessoa

// Entradas de dados
string nome = "Gustavo";
float peso = 78.5F;
float altura = 1.72F;

// Processamento dos dados
float imc = peso / (altura * altura);

Console.WriteLine($"O IMC do {nome} é de {Math.Round(imc, 2)}");
