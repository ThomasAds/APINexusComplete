using Microsoft.EntityFrameworkCore;
using APINexus.Models;
using APINexus.APINexus.Models;

namespace APINexus.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Pessoa> Pessoas { get; set; } = null!;
        public DbSet<Produto> Produtos { get; set; } = null!;
        public DbSet<Usuario> Usuarios { get; set; } = null!;
    }
}