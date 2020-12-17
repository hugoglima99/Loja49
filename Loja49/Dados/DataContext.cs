using Loja49.Dados.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Loja49.Dados
{
    public class DataContext : DbContext

    {
        public DbSet<Clientes> Clientes { get; set; }

        public DbSet<Produto> Produtos { get; set; }


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
