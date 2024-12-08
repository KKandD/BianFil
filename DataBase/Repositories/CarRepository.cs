using ApplicationCore.Interfaces;
using DataBase.Models;
using DomainModel.DomainModels;

namespace DataBase.Repositories
{
    public class CarRepository : GenericRepository<Car, CarEntity>, ICarRepository
    {
        public CarRepository(AppDbContext context) : base(context) { }

        protected override CarEntity MapToEntity(Car domain)
        {
            return new CarEntity
            {
                Id = domain.Id,
                Model = domain.Model,
                // Map other properties here
            };
        }

        protected override Car MapToDomain(CarEntity entity)
        {
            return new Car
            {
                Id = entity.Id,
                Model = entity.Model,
                // Map other properties here
            };
        }
    }
}
