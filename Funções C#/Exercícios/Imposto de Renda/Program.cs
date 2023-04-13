//faça um método para calcular imposto sobre a renda
//regras de negócio
//tabela de imposto vs renda
//até $1500 - isento
//de $1501 até $3500 - 20% de imposto
//de $3501 até $6000 - 25% de imposto
//acima de $6000 - 35% de imposto

using System.Globalization;

static float impostoRenda(float salario) {
    float imposto = 0;
    if (salario > 1500 && salario <= 3500) {
        imposto = 0.20F;
    } else if (salario > 3500 && salario <= 6000) {
        imposto = 0.25F;
    } else if (salario > 6000){
        imposto = 0.35F;
    }
    return salario * imposto;
}

Console.WriteLine($"CALCULE SEU IMPOSTO DE RENDA");

salario:
Console.Write($"Digite seu salário: R$");
float salario = float.Parse(Console.ReadLine()!);

if (salario < 0) {
    Console.WriteLine($"Salário inválido! Tente novamente.");
    goto salario;
}

Console.WriteLine($"Você deve pagar {impostoRenda(salario).ToString("C", new CultureInfo("pt-BR"))} em imposto.");
