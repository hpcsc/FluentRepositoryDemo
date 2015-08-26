using FluentRepositoryDemo.Models;
using System.Data.Entity;
using System.Linq;

namespace FluentRepositoryDemo.Repositories.QueryBuilder
{
    public class CarQueryBuilder : QueryBuilderBase<Car>
    {
        public CarQueryBuilder(DbContext context)
            : base(context)
        {
        }

        public CarQueryBuilder IsBMW()
        {
            Query = Query.Where(car => car.Brand == CarBrand.BMW);

            return this;
        }

        public CarQueryBuilder IsAvailable()
        {
            Query = Query.Where(car => car.Status == CarStatus.Available);

            return this;
        }

        public CarQueryBuilder WithMinimumPriceOf(decimal minPrice)
        {
            Query = Query.Where(car => car.RentalPricePerDay >= minPrice);

            return this;
        }

        public CarQueryBuilder WithMaximumPriceOf(decimal maxPrice)
        {
            Query.Where(car => car.RentalPricePerDay <= maxPrice);

            return this;
        }
    }
}
