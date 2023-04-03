//Coca cola
//Pepsi
//Fanta
//Monster

//crie um menu de opções e peça para o usuário escolher uma das opções
//a depender da opção, exiba uma mensagem se gostaria de acrescentar gelo
//se sim, exiba uma mensagem que a bebida em questão será com adicional de gelo
//caso contrário, a bebida é sem gelo adicional\

Console.WriteLine(@$"
/-------------------------\
|   Escolha sua bebida!   |
|-------------------------|
|    Bebidas:             |
|                         |
|    (1) Coca-Cola        |
|    (2) Pepsi            |
|    (3) Guaraná          |
|    (4) Fanta            |
|    (5) Monster          |
|                         |
\-------------------------/
");
Console.Write($"Informe o número da bebida: ");
int bebida = int.Parse(Console.ReadLine()!);

string nomeBebida = "";

switch (bebida) {
    case 1:
        nomeBebida = "Coca-Cola";
        break;
    case 2:
        nomeBebida = "Pepsi";
        break;
    case 3:
        nomeBebida = "Guaraná";
        break;
    case 4:
        nomeBebida = "Fanta";
        break;
    case 5:
        nomeBebida = "Monster";
        break;
    default:
        Console.WriteLine("Pedido inválido!");
        return;
}

Console.Write($"Deseja adicionar gelo a sua bebida? [Sim/Não] ");
string gelo = Console.ReadLine()!.ToUpper();
gelo = gelo == "SIM" ? "com gelo" : "sem gelo";

Console.WriteLine($"Pedido final: {nomeBebida} {gelo}");
