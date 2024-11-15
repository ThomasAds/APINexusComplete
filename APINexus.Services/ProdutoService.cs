using APINexus.APINexus.Models;
using APINexus.Models;

namespace APINexus.Services
{
    public class ProdutoService
    {
        private readonly List<Produto> _produtos;

        public ProdutoService()
        {
            _produtos = new List<Produto>
            {
                new Produto { Id = 1, Nome = "Produto A", Descricao = "Descrição do Produto A", Preco = 10.0m, Quantidade = 5 },
                new Produto { Id = 2, Nome = "Produto B", Descricao = "Descrição do Produto B", Preco = 20.0m, Quantidade = 10 }
            };
        }

        public async Task<List<Produto>> GetAllProdutosAsync()
        {   
            return await Task.FromResult(_produtos);
        }
        public Produto GetProdutoById(int id)
        {
            return _produtos.FirstOrDefault(p => p.Id == id) ?? new Produto();
        }
        public async Task<Produto?> GetProdutoByIdAsync(int id)
        {
            return await Task.FromResult(_produtos.FirstOrDefault(p => p.Id == id));
        }
        public async Task AddProdutoAsync(Produto produto)
        {
            await Task.Run(() => _produtos.Add(produto));
        }
        public async Task DeleteProdutoAsync(int id)
        {
            var produto = _produtos.FirstOrDefault(p => p.Id == id);
            if (produto != null)
            {
                await Task.Run(() => _produtos.Remove(produto));
            }
        }
    }
}

