using APINexus.APINexus.Models;
using APINexus.Models;
using APINexus.Services;
using Microsoft.AspNetCore.Mvc;

namespace APINexus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoService _produtoService;

        // Injeção de dependência para ProdutoService
        public ProdutoController(ProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        // GET: api/produto
        [HttpGet]
        public async Task<IActionResult> GetProdutos()
        {
            var produtos = await _produtoService.GetAllProdutosAsync();
            return Ok(produtos);
        }

        // GET: api/produto/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduto(int id)
        {
            var produto = await _produtoService.GetProdutoByIdAsync(id);
            if (produto == null)
            {
                return NotFound(new { Message = $"Produto com ID {id} não encontrado." });
            }

            return Ok(produto);
        }

        // POST: api/produto
        [HttpPost]
        public async Task<IActionResult> PostProduto(Produto produto)
        {
            if (produto == null)
            {
                return BadRequest();
            }

            await _produtoService.AddProdutoAsync(produto);
            return CreatedAtAction(nameof(GetProduto), new { id = produto.Id }, produto);
        }

        // DELETE: api/produto/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduto(int id)
        {
            await _produtoService.DeleteProdutoAsync(id);
            return NoContent();
        }
    }
}
