int idadeArtista = 0;

do {
    Console.Write($"Digite a idade do Tyler, The Creator? ");
    idadeArtista = int.Parse(Console.ReadLine()!);
} while (idadeArtista != 32);

Console.WriteLine("Parábens! Você acertou a idade do artista.");