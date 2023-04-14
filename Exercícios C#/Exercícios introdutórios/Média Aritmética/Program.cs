// Média Aritmética
// Faça um programa que receba 5 notas de um aluno e calcule a média aritmética. Imprimir a resposta no console

Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine(@$"
-------------------------------
    Calcular média do aluno
-------------------------------
");
Console.BackgroundColor = ConsoleColor.DarkRed;

float nota = 0;
for (int i = 0; i < 5; i++) {
    Console.Write($"Digite a {i + 1}º nota do aluno: ");
    nota += float.Parse(Console.ReadLine());
}
float media = (float)Math.Round((nota / 5), 2);

string situacaoAluno = media > 5 ? "Aprovado" : "Reprovado";

Console.WriteLine($"A média do aluno é: {media}");
Console.WriteLine($"Situação do aluno: {situacaoAluno}");
