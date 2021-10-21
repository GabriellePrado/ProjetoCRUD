using Microsoft.EntityFrameworkCore;
using ProjetoVendas.Data;
using ProjetoVendas.Models;
using ProjetoVendas.Services.Exceptions;
using ProjetoVendas.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoVendas.Services
{
    public class ProdutoService
    {
        private readonly ProjetoVendasContext _context;

        public ProdutoService(ProjetoVendasContext context)
        {
            _context = context;
        }
        public async Task<List<Produto>> FindAllAsync()
        {
            return await _context.Produto.ToListAsync();
        }

        public async Task InsertAsync(Produto obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Produto.FindAsync(id);
                _context.Produto.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegridadeExcecao("Não é possivel deletar um Vendedor com Vendas\n" + e.Message);
            }
        }

        public async Task UpdateAsync(Produto obj)
        {
            bool hasAny = await _context.Produto.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id nao encontrado");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }

        public async Task<Produto> FindById(int? id)
        {
            try
            {
                return await _context.Produto.FindAsync(id);

            }
            catch (DbUpdateConcurrencyException e)
            {

                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}

