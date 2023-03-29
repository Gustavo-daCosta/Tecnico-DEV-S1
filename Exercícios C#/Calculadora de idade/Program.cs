// Calculadora de Idade
// Faça um programa que receba a idade de uma pessoa e calcule a idade em meses, dias, horas e minutos. Imprima o resultado no console.

Console.Write($"Digite a idade da pessoa: ");
int idade = int.Parse(Console.ReadLine());

int meses = idade * 12;
int dias = meses * 30;
int horas = dias * 24;
int minutos = horas * 60;

Console.WriteLine(@$"
Idade: {idade} anos
Em meses: {meses} meses
Em dias: {dias} dias
Em horas: {horas} horas
Em minutos: {minutos} minutos
");
