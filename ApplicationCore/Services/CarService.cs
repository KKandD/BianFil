using ApplicationCore.Interfaces;
using DomainModel.DomainModels;

namespace ApplicationCore.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task Add(Car car)
        {
            await _carRepository.Add(car);
        }

        public async Task<List<Car>> GetAll(CancellationToken cancellationToken = default)
        {
            return await _carRepository.GetAll(cancellationToken);
        }

        public async Task<Car> GetById(int id, CancellationToken cancellationToken = default)
        {
            return await _carRepository.GetById(id, cancellationToken);
        }

        public async Task Remove(Car car)
        {
            await _carRepository.Remove(car);
        }

        public async Task Update(Car car)
        {
            await _carRepository.Update(car);
        }
    }
}
