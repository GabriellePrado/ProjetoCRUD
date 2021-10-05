using Microsoft.EntityFrameworkCore;
using ProjetoVendas.Data;
using ProjetoVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoVendas.Services
{
    public class DepartamentoService
    {
        private readonly ProjetoVendasContext _context;

        public DepartamentoService(ProjetoVendasContext context)
        {
            _context = context;
        }
        public async Task<List<Departamento>> FindAllAsync()
        {
            return  await _context.Departamento.OrderBy(x => x.Nome).ToListAsync();
        }
    }
}
