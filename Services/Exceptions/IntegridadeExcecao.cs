using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoVendas.Services.Exceptions
{
    public class IntegridadeExcecao : ApplicationException
    {
        public IntegridadeExcecao(string message) : base(message)
        {

        }

    }
}
