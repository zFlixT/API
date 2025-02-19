using API.Models;

namespace API.Repositories
{
    public interface IArticulosRepositories
    {
        Task<IEnumerable<Articulos>> Get();
        Task<Articulos?> GetById(int id);
        Task Add(Articulos producto);
        void Update(Articulos producto);
        void Delete(Articulos entity);
        Task Save();
    }
}
