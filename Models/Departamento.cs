using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoVendas.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Vendedor> Vendedor { get; set; } = new List<Vendedor>();

        public Departamento()
        {
        }
        public Departamento(string nome)
        {
           
            Nome = nome;
        }

        public void AddVendedor(Vendedor vendedor)
        {
            Vendedor.Add(vendedor);
        }
        public void RemoveVendedor(Vendedor vendedor)
        {
            Vendedor.Remove(vendedor);
        }

        public double TotalVendas(DateTime inicial, DateTime final)
        {
            return Vendedor.Sum(v => v.TotalVendas(inicial, final));
        }
    }
}
