namespace Art.Cqrs.EF
{
    public class EFUnitOfWork:IUnitOfWork
    {
        private readonly IConnectionStringProvider connectionStringProvider;
        private IDbContext dbContext;

        public EFUnitOfWork(IConnectionStringProvider connectionStringProvider)
        {
            this.connectionStringProvider = connectionStringProvider;
        }

        public IDbContext CreateContext()
        {
            dbContext = new EFDbContext(connectionStringProvider.ConnectionString);
            return dbContext;
            
        }

        public void Dispose()
        {
            dbContext.Dispose();
        }
    }
}
