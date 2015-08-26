using FluentRepositoryDemo.Repositories.QueryBuilder;
using System;
using System.Data.Entity;

namespace FluentRepositoryDemo.Repositories
{
    public class CarRepository : ISupportFluentQuery<CarQueryBuilder>, IDisposable
    {
        private readonly DbContext _context;

        public CarRepository()
        {
            _context = new DemoDbContext();
        }

        public CarQueryBuilder Query()
        {
            return new CarQueryBuilder(_context);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
