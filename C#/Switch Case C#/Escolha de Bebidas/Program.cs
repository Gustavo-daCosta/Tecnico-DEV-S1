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
|    (4) RedBull          |
|    (5) Água de Coco     |
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
        return; // Encerra o programa caso a escolha seja inválida
}

Console.WriteLine(@$"
/---------------------------------\
| Escolha o tamanho da {nomeBebida, -9}! |
|---------------------------------|
|       Tamanhos:                 |
|                                 |
|       (1) 300ml                 |
|       (2) 500ml                 |
|       (3) 700ml                 |
|       (4) 1L                    |
|       (5) 2L                    |
|                                 |
\---------------------------------/
");
Console.Write($"Informe o número do tamanho da bebida: ");
int tamanho = int.Parse(Console.ReadLine()!);
string tamanhoNome = "";

switch (tamanho) {
    case 1:
        tamanhoNome = "300ml";
        break;
    case 2:
        tamanhoNome = "500ml";
        break;
    case 3:
        tamanhoNome = "700ml";
        break;
    case 4:
        tamanhoNome = "1L";
        break;
    case 5:
        tamanhoNome = "2L";
        break;
    default:
        Console.WriteLine("Opção inválida!");
        return; // Encerra o programa caso a escolha seja inválida
}

Console.Write($"Deseja adicionar gelo a sua bebida? [S/N] ");
char gelo = char.Parse(Console.ReadLine()!.ToUpper());
string temGelo = gelo == 'S' ? "Sim" : "Não";

Console.WriteLine(@$"
╔═══════════════════════════════════════════╗
║                PEDIDO FINAL               ║
╠═══════════════════════════════════════════╣
║                                           ║
║             Bebida: {nomeBebida, -11}           ║
║             Tamanho: {tamanhoNome, -12}         ║
║             Tem gelo? {temGelo, -8}            ║
║                                           ║
╚═══════════════════════════════════════════╝
");
