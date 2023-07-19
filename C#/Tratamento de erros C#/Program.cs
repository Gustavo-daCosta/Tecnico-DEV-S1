Console.Write($"Digite um número: ");
string txtNumero = Console.ReadLine()!;

try {
    int n = int.Parse(txtNumero);

    Console.WriteLine($"O dobro de {n} é {n * 2}");
} catch (System.Exception error) {
    Console.WriteLine($"Deu pau, chame o programador");
    Console.WriteLine($"Erro: {error.Message}");
}
