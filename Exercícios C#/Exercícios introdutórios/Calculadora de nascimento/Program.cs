// Calculadora de nascimento
// Faça um programa que receba o ano do nascimento de uma pessoa e calcule a idade dessa pessoa em anos e semanas e imprima o resultado no console.

Console.Write("Digite o ano de nascimento de uma pessoa: ");
int anoNascimento = int.Parse(Console.ReadLine());
// Pega a data atual
int anoAtual = DateTime.Now.Year;

int idade = anoAtual - anoNascimento;
int idadeSemanas = idade * 52;

Console.WriteLine(@$"
Idade em anos da pessoa: {idade} anos
Idade em semanas da pessoa: {idadeSemanas} semanas
");

