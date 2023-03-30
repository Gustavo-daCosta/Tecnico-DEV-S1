// Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time) e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.

Console.Write($"Digite a quantidade de gols do primeiro time: ");
int golsPrimeiroTime = int.Parse(Console.ReadLine()!);

Console.Write($"Digite a quantidade de gols do segundo time: ");
int golsSegundoTime = int.Parse(Console.ReadLine()!);

if (golsPrimeiroTime > golsSegundoTime) {
    Console.WriteLine($"O primeiro time venceu o segundo time por {golsPrimeiroTime} x {golsSegundoTime}!");
} else if (golsPrimeiroTime < golsSegundoTime) {
    Console.WriteLine($"O segundo time venceu o primeiro time por {golsPrimeiroTime} x {golsSegundoTime}!");
} else {
    Console.WriteLine($"A partida terminou em empate entre os times! Placar: {golsPrimeiroTime} x {golsSegundoTime}!");
}
