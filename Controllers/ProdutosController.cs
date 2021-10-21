using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoVendas.Data;
using ProjetoVendas.Models;
using ProjetoVendas.Services;
using ProjetoVendas.Services.Interfaces;

namespace ProjetoVendas.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly ProdutoService _produtoService;
        private readonly ProjetoVendasContext _context;

        public ProdutosController(ProdutoService produtoService, ProjetoVendasContext context)
        {
            _produtoService = produtoService;
            _context = context;
        }

        // GET: Produtos
        public async Task<IActionResult> Index()
        {
             var list = await _produtoService.FindAllAsync();
            return View(list);
        }
       public async Task<IActionResult> Create()
         {
            var list = await _produtoService.FindAllAsync();
            return View(list);
        }
        
        // GET: Produtos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _produtoService.FindById(id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // POST: Produtos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Valor,Descrição")] Produto produto)
        {
            //verifica se tem erros de validação
            if (ModelState.IsValid)
                if (ModelState.IsValid)
            {
                await _produtoService.InsertAsync(produto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(produto);
        }

        // GET: Produtos/Edit/id
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _produtoService.FindById(id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // POST: Produtos/Edit/id
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Valor,Descrição")] Produto produto)
        {
            if (id != produto.Id)
            {
                return NotFound();
            }
            //verifica se tem erros de validação
            
            if (ModelState.IsValid)
            {
                try
                {
                    await _produtoService.UpdateAsync(produto);
                }
                catch (DbUpdateConcurrencyException)
                {
                 return NotFound();
                   
                }
                return RedirectToAction(nameof(Index));
               }
            return View(produto);
        }

        // GET: Produtos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produto = await _context.Produto
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // POST: Produtos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var produto = await _context.Produto.FindAsync(id);
            _context.Produto.Remove(produto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [ActionName("Pesquisa")]
        public async Task<IActionResult> FindByAllAsync()
        {
            var produto = await _produtoService.FindAllAsync();
            return View(produto);
        }
    }
}
