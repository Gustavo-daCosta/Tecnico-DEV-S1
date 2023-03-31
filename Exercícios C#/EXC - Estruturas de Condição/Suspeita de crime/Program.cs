//Faça um programa que faça 5 perguntas para uma pessoa sobre um crime. As perguntas são:
//"Telefonou para a vítima?" / "Esteve no local do crime?" / "Mora perto da vítima?" / "Devia para a vítima?" / "Já trabalhou com a vítima?"
//O programa deve no final emitir uma classificação sobre a participação da pessoa no crime. Se a pessoa responder positivamente a 2 questões ela deve ser classificada como "Suspeita", entre 3 e 4 como "Cúmplice" e 5 como “Culpado“. Caso contrário, ele será classificado como "Inocente“.

int respostasPositivas = 0;

string resposta = "";
List<string> perguntas = new List<string> {
    "Você telefonou para a vítima? ",
    "Você esteve no local do crime? ",
    "Você mora perto da vítima? ",
    "Você devia para a vítima? ",
    "Você já trabalhou com a vítima? "
};

foreach (string pergunta in perguntas) {
    Console.Write($"{pergunta} [sim/não] ");
    resposta = Console.ReadLine()!.ToUpper();

    if (resposta == "SIM") { respostasPositivas++; }
}

switch (respostasPositivas) {
    case 2:
        Console.WriteLine($"Você é considerado Suspeito.");
        break;
    case 3 or 4:
        Console.WriteLine($"Você é considerado Cúmplice.");
        break;
    case 5:
        Console.WriteLine($"Você é considerado Culpado.");
        break;
    default:
        Console.WriteLine($"Você é considerado Inocente.");
        break;
}
