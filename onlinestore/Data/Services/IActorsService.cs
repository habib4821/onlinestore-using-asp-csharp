using onlinestore.Models;

namespace onlinestore.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetByIdAsync(int id);
        void AddAsync(Actor actor);
        Actor Update(int id, Actor actor);
        void Delete(int id);
    }
}
