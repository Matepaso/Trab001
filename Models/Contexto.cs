using Microsoft.EntityFrameworkCore;

namespace Trab001.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Produtos> produtos { get; set; }
    }
}
