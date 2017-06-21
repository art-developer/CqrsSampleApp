using System;
using System.Linq;

namespace Art.Cqrs
{
    public interface IDbContext:IDisposable
    {
        IDbQuery<TEntity> Set<TEntity>() where TEntity : class;

        TEntity Add<TEntity>(TEntity entity) where TEntity:class;
        int SaveChanges();
    }
}
