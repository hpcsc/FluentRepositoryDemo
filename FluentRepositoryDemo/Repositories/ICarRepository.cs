using FluentRepositoryDemo.Repositories.QueryBuilder;

namespace FluentRepositoryDemo.Repositories
{
    public interface ICarRepository : ISupportFluentQuery<CarQueryBuilder>
    {
    }
}
