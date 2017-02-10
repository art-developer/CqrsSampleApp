using System;

namespace Art.Cqrs
{
    public interface IUnitOfWork:IDisposable
    {
        IDbContext CreateContext();
    }
}
