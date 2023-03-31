// Faça um programa que verifique se uma letra digitada é vogal ou consoante

Console.Write($"Digite uma letra do alfabeto: ");
char letra = char.Parse(Console.ReadLine()!.ToUpper());

List<char> vogais = new List<char> {'A', 'E', 'I', 'O', 'U'};

if (vogais.Contains(letra)) {
    Console.WriteLine($"A letra {letra} é vogal!");
} else {
    Console.WriteLine($"A letra {letra} é consoante!");
}
