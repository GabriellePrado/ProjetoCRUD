using ProjetoVendas.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoVendas.Models
{
    public class RegistroVendas
    {
        public int Id { get; set; }
        public double Valor { get; set; }
        public StatusVendas Status { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Data { get; set; }
        public Vendedor Vendedor { get; set; }
        public Produto Produto { get; set; }
        public RegistroVendas()
        {
        }
        public RegistroVendas(int id, DateTime data, double valor, StatusVendas status,  Vendedor vendedor, Produto produto)
        {
            Id = id;
            Valor = valor;
            Status = status;
            Data = data;
            Vendedor = vendedor;
            Produto = produto;
        }
    }
}
