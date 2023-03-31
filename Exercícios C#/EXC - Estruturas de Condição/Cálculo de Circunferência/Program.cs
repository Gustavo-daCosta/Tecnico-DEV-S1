// Escreva um programa que pergunte o raio de uma circunferência, e sem seguida mostre o diâmetro, comprimento e área da circunferência.

Console.Write($"Digite o raio de uma circunferência: ");
float raio = float.Parse(Console.ReadLine()!);

float diametro = (float)(raio * 2);
float circunferencia = (float)((2 * Math.PI) * raio);
float area = (float)(Math.PI * Math.Pow(raio, 2));

Console.WriteLine(@$"
Raio: {raio} cm
Diâmetro: {diametro} cm
Circunferência: {circunferencia} cm
Área: {area} cm
");
