using API.Context;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories
{
    public class ArticulosRepositories : IArticulosRepositories
    {
        private readonly ArticulosContext _context;

        public ArticulosRepositories(ArticulosContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Articulos>> Get() => await _context.Articulos.ToListAsync();

        public async Task<Articulos?> GetById(int id) => await _context.Articulos.FindAsync(id);

        public async Task Add(Articulos producto) => await _context.Articulos.AddAsync(producto);

        public void Update(Articulos entity)
        {
            _context.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(Articulos entity) => _context.Articulos.Remove(entity);

        public async Task Save() => await _context.SaveChangesAsync();
    }
}
