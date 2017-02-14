using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Art.Cqrs;
using Art.Cqrs.EF;

namespace SampleApp.Cqrs.EF
{
    public class SampleAppUnitOfWork:EFUnitOfWork
    {
        public SampleAppUnitOfWork(IConnectionStringProvider connectionStringProvider) : base(connectionStringProvider)
        {
        }

        public override IDbContext CreateContext()
        {
            return new SampleAppDbContext(connectionStringProvider.ConnectionString);
        }
    }
}
