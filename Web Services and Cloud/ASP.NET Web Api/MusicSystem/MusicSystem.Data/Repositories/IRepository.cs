﻿namespace MusicSystem.Data.Repositories
{
    using System.Linq;

    public interface IRepository<T>
    {
        IQueryable<T> All();

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        int SaveChanges();
    }
}
