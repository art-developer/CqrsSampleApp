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

        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasKey(t => t.UNLEC);
            modelBuilder.Entity<Drug>().Property(t => t.UNLEC).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<Drug>().Property(t => t.LECLAT).HasMaxLength(12);
            modelBuilder.Entity<Drug>().Property(t => t.LECLAT).HasColumnType("varchar");
            modelBuilder.Entity<Drug>().Property(t => t.LECLAT).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<Drug>().Property(t => t.LECLAT).HasColumnName("LECLAT");
            modelBuilder.Entity<Drug>().ToTable("REPLLEC");
        }*/

        public TEntity Add<TEntity>(TEntity entity) where TEntity:class
        {
            return base.Set<TEntity>().Add(entity);
        }
    }
}
