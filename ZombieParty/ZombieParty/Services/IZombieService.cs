using Microsoft.AspNetCore.Mvc.Rendering;
using ZombieParty.Models;

namespace ZombieParty.Services
{
    public interface IZombieService : IServiceBaseAsync<Zombie>
    {
        Task<IReadOnlyList<Zombie>> GetAllByZombieTypeAsync(int zombieTypeId);
        Task<IReadOnlyList<Zombie>> GetAllIndexAsync();
    }
}
