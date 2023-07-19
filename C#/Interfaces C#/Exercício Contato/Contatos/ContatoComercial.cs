using ClasseContato;
using InterfaceContatoComercial;

namespace ClasseContatoComercial
{
    public class ContatoComercial : Contato, IContatoComercial
    {
        public string? Cnpj { get; set; }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}