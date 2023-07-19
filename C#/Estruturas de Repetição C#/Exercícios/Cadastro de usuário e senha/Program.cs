// Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as informações.

string nomeUsuario = "";
string senha = "";

while (nomeUsuario == senha) {
    Console.Write($"Digite o nome de usuário: ");
    nomeUsuario = Console.ReadLine()!;

    Console.Write("Digite a senha: ");
    senha = Console.ReadLine()!;

    if (nomeUsuario == senha) {
        Console.WriteLine($"Usuário e senha iguais! Cadastro inválido.");
    }
}

Console.WriteLine($"Cadastro concluído!");