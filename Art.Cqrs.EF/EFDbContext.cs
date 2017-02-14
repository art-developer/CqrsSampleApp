using System.Data.Entity;
using System.Linq;

namespace Art.Cqrs.EF
{
    public class EFDbContext : DbContext,IDbContext
    {
        public EFDbContext(string connectionString) : base(connectionString)
        {
            
        }

        IQueryable<T> IDbContext.Set<T>()
        {
            return base.Set<T>();
        }

        public TEntity Add<TEntity>(TEntity entity) where TEntity:class
        {
            return base.Set<TEntity>().Add(entity);
        }
    }
}
