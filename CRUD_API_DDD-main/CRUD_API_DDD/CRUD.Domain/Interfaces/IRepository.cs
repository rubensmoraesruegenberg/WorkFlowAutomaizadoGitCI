﻿using CRUD.Domain.Models;

namespace CRUD.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        Task<long> GetAllCountAsync();

        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<TEntity> GetByMatriculaAsync(int id);

        Task<TEntity> GetByIdAsync(long id);

        Task InsertAllAsync(IEnumerable<TEntity> entities);

        Task InsertAsync(TEntity entity);

        Task UpdateAsync(TEntity entity);

        Task UpdateAllAsync(IEnumerable<TEntity> entities);

        Task DeleteAsync(TEntity entity);

        Task DeleteAllAsync(IEnumerable<TEntity> entities);

        Task SaveChangesAsync();
    }
}
