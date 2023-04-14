int anoAtual = DateTime.Now.Year;

ano:
Console.Write($"Digite o seu ano de nascimento: ");
int anoNascimento = int.Parse(Console.ReadLine()!);

if (anoNascimento > anoAtual) {
    Console.WriteLine($"Data de nascimento inválida! Tente novamente");
    goto ano;
}

int idade = anoAtual - anoNascimento;

if (idade < 16) {
    Console.WriteLine($"Você não tem idade suficiente para votar.");
} else if (idade == 16 || idade == 17 || idade >= 60) {
    Console.WriteLine($"Você pode votar, porém seu voto é opcional.");
} else {
    Console.WriteLine($"Você pode votar e o seu voto é obritgatório.");
}
