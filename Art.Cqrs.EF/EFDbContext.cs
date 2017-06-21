using System.Data.Entity;
using System.Linq;

namespace Art.Cqrs.EF
{
    public class EFDbContext : DbContext,IDbContext
    {
        public EFDbContext(string connectionString) : base(connectionString)
        {
        }

        IDbQuery<T> IDbContext.Set<T>()
        {
            return new EFDbQuery<T>(base.Set<T>());
        }

        public TEntity Add<TEntity>(TEntity entity) where TEntity:class
        {
            return base.Set<TEntity>().Add(entity);
        }
    }
}
