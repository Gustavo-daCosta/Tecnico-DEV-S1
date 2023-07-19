using ClasseContato;
using ClasseContatoPessoal;
using ClasseContatoComercial;

List<Contato> contatos = new List<Contato>();

contatos.Add(new ContatoPessoal());
contatos.Add(new ContatoComercial());

static void Mensagem(string mensagem, ConsoleColor color = ConsoleColor.Red) {
    Console.Clear();
    Console.ForegroundColor = color;
    Console.WriteLine(mensagem);
    Console.ResetColor();
    Console.WriteLine($"Aperte ENTER para continuar...");
    Console.ReadLine();
    Console.Clear();
}

static int Menu() {
    menu:
    Console.Clear();
    Console.WriteLine($" === AGENDA  ===");
    Console.WriteLine(@$"Selecione uma opção:
    
    [1] - Adicionar contato
    [2] - Remover contato
    [3] - Listar contatos

    [0] - Sair
    ");
    Console.Write($"Digite a opção desejada: ");
    int opcao = int.Parse(Console.ReadLine()!);

    if (opcao < 0 || opcao > 3) {
        Mensagem($"Opção inválida! Tente novamente.");
        Console.ReadLine();
        goto menu;
    }
    return opcao;
}

bool desejaContinuar = true;
while (desejaContinuar) {
    int opcao = Menu();

    switch (opcao) {
        case 1:
            
    }
}
