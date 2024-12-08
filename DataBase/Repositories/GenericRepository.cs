using ApplicationCore.Interfaces;
using DataBase.Models;
using DomainModel.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Repositories
{
    public class GenericRepository<TDomain, TEntity> : IGenericRepository<TDomain>
        where TDomain : BaseDomain
        where TEntity : BaseEntity
    {
        protected readonly AppDbContext _context;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task Add(TDomain domainEntity)
        {
            var dbEntity = MapToEntity(domainEntity);
            await _context.Set<TEntity>().AddAsync(dbEntity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(TDomain domainEntity)
        {
            var dbEntity = MapToEntity(domainEntity);
            _context.Set<TEntity>().Update(dbEntity);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(TDomain domainEntity)
        {
            var dbEntity = MapToEntity(domainEntity);
            _context.Set<TEntity>().Remove(dbEntity);
            await _context.SaveChangesAsync();
        }

        public async Task<TDomain> GetById(int id, CancellationToken cancellationToken = default)
        {
            var dbEntity = await _context.Set<TEntity>().FindAsync(new object[] { id }, cancellationToken);
            return MapToDomain(dbEntity);
        }

        public async Task<List<TDomain>> GetAll(CancellationToken cancellationToken = default)
        {
            var dbEntities = await _context.Set<TEntity>().ToListAsync(cancellationToken);
            return dbEntities.Select(MapToDomain).ToList();
        }

        protected virtual TEntity MapToEntity(TDomain domain) => throw new NotImplementedException();
        protected virtual TDomain MapToDomain(TEntity entity) => throw new NotImplementedException();
    }
}
