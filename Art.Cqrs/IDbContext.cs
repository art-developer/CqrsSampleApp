using System;
using System.Linq;

namespace Art.Cqrs
{
    public interface IDbContext:IDisposable
    {
        IQueryable<TEntity> Set<TEntity>() where TEntity : class;

        TEntity Add<TEntity>(TEntity entity) where TEntity:class;
        int SaveChanges();
        void Dispose();
    }
}
