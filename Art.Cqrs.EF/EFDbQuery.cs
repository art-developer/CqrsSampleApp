using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Art.Cqrs.EF
{
    public class EFDbQuery<TResult> : IDbQuery<TResult>
    {
        private readonly DbQuery<TResult> dbQuery;
        public EFDbQuery(DbQuery<TResult> dbQuery)
        {
            this.dbQuery = dbQuery;
        }

        public IDbQuery<TResult> Include(string path)
        {
            return new EFDbQuery<TResult>(dbQuery.Include(path));
        }

        public IDbQuery<TResult> Include<TProperty>(Expression<Func<TResult, TProperty>> path)
        {
            return (EFDbQuery<TResult>)QueryableExtensions.Include(this, path);

        }

        public IEnumerator<TResult> GetEnumerator()
        {
            return ((IEnumerable<TResult>)dbQuery).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Expression Expression => ((IQueryable)dbQuery).Expression;
        public Type ElementType => ((IQueryable)dbQuery).ElementType;
        public IQueryProvider Provider => ((IQueryable)dbQuery).Provider;
    }
}
