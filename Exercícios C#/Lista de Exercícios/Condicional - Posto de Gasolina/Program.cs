using System.Globalization;

static float CalcularCombustivel(int opcaoCombustivel, int litros) {
    float precoLitro = 0;
    float desconto = 0;
    switch (opcaoCombustivel) {
        // Caso seja álcool
        case 1:
            precoLitro = 4.9F;
            desconto = precoLitro * (litros < 20 ? 0.03F : 0.05F);
            break;
        // Caso seja gasolina
        case 2:
            precoLitro = 5.3F;
            desconto = precoLitro * (litros < 20 ? 0.04F : 0.06F);
            break;
        default:
            break;
    }
    return (litros * (precoLitro - desconto));
}

Console.WriteLine($"    POSTO DE COMBUSTÍVEL");
Console.WriteLine(@$"
    Selecione um combustível:

    [1] Álcool
    [2] Gasolina
");

opcaoCombustivel:
Console.Write("Selecione uma opção: ");
int opcao = int.Parse(Console.ReadLine()!);

if (opcao != 1 && opcao != 2) {
    Console.WriteLine($"Opção inválida! Tente novamente.");
    goto opcaoCombustivel;
}

litros:
Console.Write($"Digite quantos litros de combustível você deseja: ");
int litros = int.Parse(Console.ReadLine()!);

if (litros < 0) {
    Console.WriteLine("Valor inválido! Tente novamente.");
    goto litros;
}

Console.WriteLine($"Valor total a se pagar: {CalcularCombustivel(opcao, litros).ToString("C", new CultureInfo("pt-BR"))}");
