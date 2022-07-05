﻿namespace HotelListing.Api.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(int id);
        Task<List<T>> GetAllAsync();
        IQueryable<T> GetAll();
        Task<T> AddAsync(T entity);
        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);
        Task<bool> Exists(int id);
    }
}
