using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceContatoPessoal
{
    public interface IContatoPessoal
    {
        public bool ValidarCpf(string cpf);
    }
}