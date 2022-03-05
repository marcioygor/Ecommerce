using Microsoft.EntityFrameworkCore;
using SiteDeCompra.Models;

namespace SiteDeCompra.Data
{
    public class ApplicationDBcontext : DbContext
    {
        public ApplicationDBcontext(DbContextOptions<ApplicationDBcontext> options) : base(options)
        {
        }

        //public DbSet<ProductTypes> ProductTypes { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<CompraUsuario> CompraUsuario { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }

    }
}