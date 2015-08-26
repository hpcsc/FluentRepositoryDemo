using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace FluentRepositoryDemo.Repositories.QueryBuilder
{
    public abstract class QueryBuilderBase<T> where T : class
    {
        protected IQueryable<T> Query;
        protected QueryBuilderBase(DbContext context)
        {
            Query = context.Set<T>();
        }

        public List<T> ToList()
        {
            return Query.ToList();
        }

        public T FirstOrDefault()
        {
            return Query.FirstOrDefault();
        }

        public static implicit operator List<T>(QueryBuilderBase<T> queryBuilder)
        {
            return queryBuilder.ToList();
        }

        public static implicit operator T(QueryBuilderBase<T> queryBuilder)
        {
            return queryBuilder.FirstOrDefault();
        }
    }
}
