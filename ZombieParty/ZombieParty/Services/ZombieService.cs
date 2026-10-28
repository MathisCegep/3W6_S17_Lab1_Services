using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ZombieParty.Models;
using ZombieParty.Models.Data;

namespace ZombieParty.Services
{
    public class ZombieService : ServiceBaseAsync<Zombie>, IZombieService
    {
        public ZombieService(ZombiePartyDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IReadOnlyList<Zombie>> GetAllByZombieTypeAsync(int zombieTypeId)
        {
            return await _dbContext.Zombies.Where(z => z.ZombieTypeId == zombieTypeId).ToListAsync();
        }

        public async Task<IReadOnlyList<Zombie>> GetAllIndexAsync()
        {
            return await _dbContext.Zombies.OrderBy(z => z.Name).Include(z => z.ZombieType).ToListAsync();
        }



    }
}
