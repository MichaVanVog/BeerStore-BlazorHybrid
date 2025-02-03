using BeerStore.CoreBusiness;
using BeerStore.UseCases.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace BeerStore.Db.Repositories
{
    public class SubdivisionRepository(DatabaseContext databaseContext) : ISubdivisionRepository
    {
        readonly DatabaseContext databaseContext = databaseContext;
        public async Task AddSubdivisionAsync(Subdivision subdivision)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteSubdivisionAsync(Subdivision subdivision)
        {
            databaseContext.Subdivisions.Remove(subdivision);
            await databaseContext.SaveChangesAsync();
        }

        public async Task<Subdivision> GetSubdivisionAsync(int id)
        {
            return await databaseContext.Subdivisions.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<IEnumerable<Subdivision>> GetSubdivisionsAsync()
        {
            return await databaseContext.Subdivisions.ToListAsync();
        }

        public async Task UpdateSubdivisionAsync(Subdivision subdivision)
        {
            databaseContext.Subdivisions.Update(subdivision);
            await databaseContext.SaveChangesAsync();
        }
    }
}
