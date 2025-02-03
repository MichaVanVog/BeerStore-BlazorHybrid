using BeerStore.CoreBusiness;

namespace BeerStore.UseCases.RepositoryInterfaces
{
    public interface ISubdivisionRepository
    {
        Task<IEnumerable<Subdivision>> GetSubdivisionsAsync();
        Task<Subdivision> GetSubdivisionAsync(int id);
        Task AddSubdivisionAsync(Subdivision subdivision);
        Task UpdateSubdivisionAsync(Subdivision subdivision);
        Task DeleteSubdivisionAsync(Subdivision subdivision);
    }
}
