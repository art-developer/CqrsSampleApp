namespace Art.Cqrs.EF
{
    public class EFUnitOfWork:IUnitOfWork
    {
        protected readonly IConnectionStringProvider connectionStringProvider;
        private IDbContext dbContext;

        public EFUnitOfWork(IConnectionStringProvider connectionStringProvider)
        {
            this.connectionStringProvider = connectionStringProvider;
        }

        public virtual IDbContext CreateContext()
        {
            dbContext = new EFDbContext(connectionStringProvider.ConnectionString);
            return dbContext;
            
        }

        public void Dispose()
        {
            dbContext?.Dispose();
        }
    }
}
