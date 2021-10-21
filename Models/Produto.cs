using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoVendas.Models
{
    public class Produto
    {
        
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Nome { get; set; }

        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        public double Valor { get; set; }

        [Display(Name = "Descrição")]
        [StringLength(200, MinimumLength = 3)]
        public string Descricao { get; set; }
        //public ICollection<Produto> ListaProdutos { get; set; } = new List<Produto>();

        public Produto()
        {
        }
        public Produto(string nome, double valor, string descricao)
        {
            Nome = nome;
            Valor = valor;
            Descricao = descricao;
          
        }
    }
}
