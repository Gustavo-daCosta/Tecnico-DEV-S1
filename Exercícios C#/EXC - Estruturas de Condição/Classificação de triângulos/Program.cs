// Escreva um programa que leia as medidas dos lados de um triângulo e escreva se ele é Equilátero, Isósceles ou  Escaleno. Sendo que:    
// − Triângulo    Equilátero:    possui    os    3    lados    iguais.
// − Triângulo    Isóscele:    possui    2    lados    iguais.
// − Triângulo    Escaleno:    possui    3    lados    diferentes.

Console.Write($"Digite a medida do 1º lado do triângulo: ");
float lado1 = float.Parse(Console.ReadLine()!);

Console.Write($"Digite a medida do 2º lado do triângulo: ");
float lado2 = float.Parse(Console.ReadLine()!);

Console.Write($"Digite a medida do 3º lado do triângulo: ");
float lado3 = float.Parse(Console.ReadLine()!);

if ((lado1 == lado2) && (lado2 == lado3)) { // Triângulo Equilátero
    Console.WriteLine("O triângulo é Equilátero! (todos os lados são iguais)");
} else if ((lado1 == lado2) || (lado2 == lado3) || (lado1 == lado3)) { // Triângulo Isósceles
    Console.WriteLine("O triângulo é Isósceles! (possui 2 lados iguais)");
} else { // Triângulo Escaleno
    Console.WriteLine("O triângulo é Escaleno! (todos os lados são diferentes)");
}
