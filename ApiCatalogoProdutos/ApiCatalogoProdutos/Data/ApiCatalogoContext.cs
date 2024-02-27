using ApiCatalogoProdutos.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalogoProdutos.Data
{
    public class ApiCatalogoContext : DbContext
    {
        public ApiCatalogoContext(DbContextOptions<ApiCatalogoContext> options) : base(options)
        {
        }

        public DbSet<Produto>? Produtos { get; set; }
        public DbSet<Categoria>? Categorias { get; set; }
    }
}
