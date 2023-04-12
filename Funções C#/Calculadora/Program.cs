// Crie um metódo para somar 2 números

desejaContinuar = true;

static void Menu() {
    Console.Clear();
    Console.WriteLine(@$"
┌------------------------------------┐
|            CALCULADORA             |
└------------------------------------┘
┌------------------------------------┐
|       Selecione uma opção:         |
|                                    |
|       [1] - Somar                  |
|       [2] - Subtrair               |
|       [3] - Multiplicar            |
|       [4] - Dividir                |
|                                    |
└------------------------------------┘
    ");
}

static float Somar(float n1, float n2) {
    return n1 + n2;
}

static float Subtrair(float n1, float n2) {
    return n1 - n2;
}

static float Multiplicar(float n1, float n2) {
    return n1 * n2;
}

static float Dividir(float n1, float n2) {
    return n1 / n2;
}

while (desejaContinuar) {
    int opcao = 0;
    while (opcao <= 0 || opcao > 4) {
        Menu();
        Console.WriteLine($"Selecione uma opção: ");
        opcao = int.Parse(Console.ReadLine()!);

        if (opcao <= 0 || opcao > 4) {
            Console.WriteLine("Opção Inválida! Tente novamente.");
            Console.Write($"Aperte qualquer tecla para continuar...");
            Console.Readline();
        }
    }

    float n1, n2;
    bool numerosValidos = false;
    while (numerosValidos == false) {
        Console.Write($"Digite o 1º número da operação: ");
        n1 = float.Parse(Console.ReadLine()!);

        Console.Write($"Digite o 2º número da operação: ");
        n2 = float.Parse(Console.ReadLine()!);
    }

    float resultado = 0;

    switch (opcao) {
        case 1:
            resultado = Somar(n1, n2);
            break;
        case 2:
            resultado = Subtrair(n1, n2);
            break;
        case 3:
            resultado = Multiplicar(n1, n2);
            break;
        case 4:
            resultado = Dividir(n1, n2);
            break;
    }

    Console.WriteLine($"O resultado é {resultado}");
}
