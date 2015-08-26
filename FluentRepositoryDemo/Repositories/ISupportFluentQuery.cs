
namespace FluentRepositoryDemo.Repositories
{
    public interface ISupportFluentQuery<TQueryBuilder> where TQueryBuilder : class
    {
        TQueryBuilder Query();
    }
}
