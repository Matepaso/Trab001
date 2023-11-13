
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Trab001.Models
{
    public class ContextoUsuario : DbContext
    {
        public ContextoUsuario(DbContextOptions<ContextoUsuario> options) : base(options)
        {

        }

        public DbSet<Usuario> usuarios { get; set; }
    }
}
