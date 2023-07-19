using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceContatoComercial
{
    public interface IContatoComercial
    {
        public bool ValidarCnpj(string cnpj);
    }
}