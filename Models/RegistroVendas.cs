using ProjetoVendas.Models.Enums;
using System;

namespace ProjetoVendas.Models
{
    public class RegistroVendas
    {
        public int Id { get; set; }
        public double Valor { get; set; }
        public StatusVendas Status { get; set; }
        public DateTime Data { get; set; }
        public Vendedor Vendedor { get; set; }
        public RegistroVendas()
        {
        }
        public RegistroVendas(int id, double valor, StatusVendas status, DateTime data, Vendedor vendedor)
        {
            Id = id;
            Valor = valor;
            Status = status;
            Data = data;
            Vendedor = vendedor;
        }
    }
}
