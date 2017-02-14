using System;

namespace Art.Cqrs
{
    public interface IUnitOfWork
    {
        IDbContext CreateContext();
    }
}
