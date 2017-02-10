using System.Collections.Generic;
using Art.Cqrs;
using SampleApp.Domain;

namespace SampleApp.IQueries
{
    public interface IGetOrdersQuery:IFindAllQuery<IList<Order>>
    {
        
    }
}
