using ProjetoVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoVendas.Services.Interfaces
{
    public interface IProdutoService
    {
        Task<List<Produto>> FindAllAsync();

        Task InsertAsync(Produto obj);

        Task RemoveAsync(int id);

        Task Update(Produto obj);

        Task<Produto> FindById(int? id);
    }
}
