// string name = "Gustavo";
// int idade = 16;

// Console.WriteLine com concatenação
// Console.WriteLine("Concatenação: Meu nome é " + name + " e eu tenho " + idade + " anos.");


// Console.WriteLine com interpolação
// Console.WriteLine($"Interpolação: Meu nome é {name} e eu tenho {idade} anos.");

// int quantidade = 10;
// double preco = 4.9999999999D;
// float altura = 1.80F;
// bool careca = true;
// string text = "Olá mundo";
// char letra = 'C';

// Operadores aritméticos

// Soma
Console.WriteLine($"Soma: 4 + 4 = {4 + 4}");
Console.WriteLine(4 + "4");

// Subtração
Console.WriteLine($"Subtração: 10 - 8 = {10 - 8}");

// Multiplicação
Console.WriteLine($"Multiplicação: 5 * 9 = {5 * 9}");

// Divisão
Console.WriteLine($"Divisão: 10 / 2 = {10 / 2}");

// Modular (resto da divisão)
Console.WriteLine($"Modular: 5 % 2 = {5 % 2}");


// Operadores de comparação - Resposta true ou false

// Igual a
Console.WriteLine($"Igual a: 5 == 6? {5 == 6}");

// Maior ou igual a
Console.WriteLine($"Maior ou igual a: 5 >= 4? {5 >= 4}");

// Menor ou igual a
Console.WriteLine($"Menor ou igual a: 4 <= 4? {4 <= 4}");

// Maior que
Console.WriteLine($"Maior que: 5 > 1? {5 > 1}");

// Menor que
Console.WriteLine($"Menor que: 5 < 2? {5 < 2}");

// Diferente de
Console.WriteLine($"Diferente de: 5 != 8? {5 != 8}");


// Operadores lógicos


// && : e
Console.WriteLine(5 == 5 && 8 == 8); // true && true = true
Console.WriteLine(5 == 5 && 8 == 9); // true && false = false
Console.WriteLine(5 == 6 && 8 == 9); // false && false = false

// || : ou
Console.WriteLine(5 == 5 || 8 == 8); // true || true = true
Console.WriteLine(5 == 5 || 8 == 9); // true || false = true
Console.WriteLine(5 == 6 || 8 == 9); // false || false = false

// !  : negação 
Console.WriteLine(!(2 == 4 || 3 == 8)); // !(false || false) = false
Console.WriteLine(5 == 5 || 8 == 9); // true || false = true
Console.WriteLine(5 == 6 || 8 == 9); // false || false = false
