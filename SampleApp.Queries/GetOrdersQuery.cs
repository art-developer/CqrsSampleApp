using System.Collections.Generic;
using System.Linq;
using Art.Cqrs;
using SampleApp.Domain;
using SampleApp.IQueries;

namespace SampleApp.Queries
{
    public class GetOrdersQuery: IGetOrdersQuery
    {
        private readonly IUnitOfWork unitOfWork;
        public GetOrdersQuery(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IList<Order> Execute()
        {
            using (var dbContext = unitOfWork.CreateContext())
            {
                return dbContext.Set<Order>().ToList();
            }
        }
    }
}
