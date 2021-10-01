using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teste1.Models.Departamento
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
