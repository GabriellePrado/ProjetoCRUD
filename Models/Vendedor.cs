using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ProjetoVendas.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        //esse campo é obrigatorio:
        [Required(ErrorMessage = "{0} é obrigatorio")]
        //limite min e max:
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Tamanho do {0} deve ser maior que {2} e menor que {1}")]
        public string Nome { get; set; }

        [EmailAddress(ErrorMessage = "Digite um email valido")]
        [Required(ErrorMessage = "{0} é obrigatorio")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} é obrigatorio")]
        [Display(Name = "Data de nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime DataDeNascimento { get; set; }

        [Required(ErrorMessage = "{0} é obrigatorio")]
        [Range(100.0, 50000.0, ErrorMessage = "Digite um {0} maior que {2} e menor que {1}")]
        [Display(Name = "Salario")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double SalarioBase { get; set; }
       
        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }
        public ICollection<RegistroVendas> Vendas { get; set; } = new List<RegistroVendas>();

        public Vendedor()
        {
        }

        public Vendedor(int id, string nome, string email, DateTime dataDeNascimento, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            SalarioBase = salarioBase;
            DataDeNascimento = dataDeNascimento;
            Departamento = departamento;
        }

        public void AddVenda(RegistroVendas venda)
        {
            Vendas.Add(venda);
        }
        public void RemoveVenda(RegistroVendas venda)
        {
            Vendas.Add(venda);
        }

        public double TotalVendas(DateTime inicial, DateTime final)
        {
            //esse metodo retorna o numero total de vendas no periodo x até o y.
            return Vendas.Where(sr => sr.Data >= inicial && sr.Data <= final).Sum(sr => sr.Valor);
        }
    }
}
