using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Art.Cqrs
{
    public interface IDbQuery<TResult> : IQueryable<TResult>
    {
        IDbQuery<TResult> Include(string path);
        IDbQuery<TResult> Include<TProperty>(Expression<Func<TResult, TProperty>> path);

    }
}
