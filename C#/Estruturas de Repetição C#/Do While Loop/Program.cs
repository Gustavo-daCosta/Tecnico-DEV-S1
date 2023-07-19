int idadeCerta = 0;

do {
    Console.Write($"Qual a idade do Adulto Ney? ");
    int idade =int.Parse(Console.ReadLine()!);

    if (idade == 32) {
        Console.WriteLine($"Acertou !!S");
        idadeCerta = 0;
    }
    else {
        Console.WriteLine($"Errou feio ! Tente novamente ");
    }

} while (idadeCerta == 32);