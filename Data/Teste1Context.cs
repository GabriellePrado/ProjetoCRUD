using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Teste1.Models.Departamento;

namespace Teste1.Data
{
    public class Teste1Context : DbContext
    {
        public Teste1Context (DbContextOptions<Teste1Context> options)
            : base(options)
        {
        }

        public DbSet<Teste1.Models.Departamento.Departamento> Departamento { get; set; }
    }
}
