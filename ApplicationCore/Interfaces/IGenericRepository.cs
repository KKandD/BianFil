using DomainModel.DomainModels;

namespace ApplicationCore.Interfaces
{
    public interface IGenericRepository<TDomain>
    where TDomain : BaseDomain
    {
        Task Add(TDomain entity);
        Task Update(TDomain entity);
        Task Remove(TDomain entity);
        Task<TDomain> GetById(int id, CancellationToken cancellationToken = default);
        Task<List<TDomain>> GetAll(CancellationToken cancellationToken = default);
    }
}