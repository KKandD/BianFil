using DomainModel.DomainModels;

namespace ApplicationCore.Interfaces
{
    public interface ICarService
    {
        Task Add(Car car);
        Task Update(Car car);
        Task Remove(Car car);
        Task<Car> GetById(int id, CancellationToken cancellationToken = default);
        Task<List<Car>> GetAll(CancellationToken cancellationToken = default);
    }
}
