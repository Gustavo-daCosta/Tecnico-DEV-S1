int idadeArtista = 0;

while (idadeArtista != 32) {
    Console.Write($"Digite a idade do Tyler, The Creator? ");
    idadeArtista = int.Parse(Console.ReadLine()!);
}

Console.WriteLine("Parábens! Você acertou a idade do artista.");