using ClasseContato;
using ClasseContatoPessoal;
using ClasseContatoComercial;

List<Contato> contatos = new List<Contato>();

contatos.Add(new ContatoPessoal());
contatos.Add(new ContatoComercial());

Console.WriteLine(contatos.Count);
