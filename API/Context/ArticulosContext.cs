using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Context
{
    public class ArticulosContext : DbContext
    {
        public ArticulosContext(DbContextOptions<ArticulosContext> options) : base(options) 
        {
        }
        public DbSet<Articulos> Articulos { get; set; }
    }
}
