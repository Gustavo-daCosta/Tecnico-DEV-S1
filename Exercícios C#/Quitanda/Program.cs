// Quitanda
// Faça um programa para uma quitanda que possibilite o usuário escolher entre diversas opções e mostre seus preços
// Depois de escolher o produto posisibilite o usuário a escolher quantos kg ele quer do produto

bool continuarPrograma = true;

List<List<dynamic>> produtos = new List<List<dynamic>>();
produtos.Add(new List<dynamic>[2]);

while (continuarPrograma) {
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.WriteLine(@$"
    --------------------------
            QUITANDA
    --------------------------
    ");
    Console.WriteLine(@$"
    Selecione um produto da quitanda:
    [1] - Cenoura   | R$4,99/Kg
    [2] - Laranja   | R$7,99/Kg
    [3] - Tomate    | R$2,99/Kg
    [4] - Banana    | R$8,99/Kg
    [5] - Cebola    | R$5,99/Kg
    ");
    Console.BackgroundColor = ConsoleColor.DarkCyan;

    Console.Write("Selecione uma opção: ");
    int opcao = int.Parse(Console.ReadLine()!);

    Dictionary<string, dynamic> item = new Dictionary<string, dynamic>();

    switch (opcao) {
        case 1:
            item = produtos[opcao];
            break;
        case 2:

            break;
        case 3:

            break;
        case 4:

            break;
        case 5:

            break;

        default:
            Console.WriteLine("A opção digitada é inválida!");
            Console.WriteLine("Por favor, digite uma opção válida.");
            break;
    }
}
