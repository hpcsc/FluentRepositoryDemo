
using FluentRepositoryDemo.Repositories.QueryBuilder;
namespace FluentRepositoryDemo.Repositories
{
    public interface ISupportFluentQuery<TQueryBuilder>
        where TQueryBuilder : IAmQueryBuilder
    {
        TQueryBuilder Query();
    }
}
