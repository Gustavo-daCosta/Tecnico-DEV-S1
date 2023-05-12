using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClasseContato;
using InterfaceContatoPessoal;

namespace ClasseContatoPessoal
{
    public class ContatoPessoal : Contato, IContatoPessoal
    {
        public string? Cpf { get; set; }

        public bool ValidarCpf(string cpf)
        {
            throw new NotImplementedException();
        }
    }
}