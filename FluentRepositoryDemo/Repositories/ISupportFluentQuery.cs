
using FluentRepositoryDemo.Repositories.QueryBuilder;
namespace FluentRepositoryDemo.Repositories
{
    public interface ISupportFluentQuery<TQueryBuilder> 
        where TQueryBuilder : QueryBuilderBase
    {
        TQueryBuilder Query();
    }
}
