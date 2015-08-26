using FluentRepositoryDemo.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace FluentRepositoryDemo.Repositories
{
    public class DbInitializer : DropCreateDatabaseAlways<DemoDbContext>
    {
        protected override void Seed(DemoDbContext context)
        {
            var cars = new List<Car>
            {
                new Car { Brand = CarBrand.BMW, Model = "M235i", RentalPricePerDay = 90, Status = CarStatus.Available },
                new Car { Brand = CarBrand.Cadillac, Model = "CTS", RentalPricePerDay = 80, Status = CarStatus.Reserved },
                new Car { Brand = CarBrand.Chevrolet, Model = "Corvette Stingray", RentalPricePerDay = 85, Status = CarStatus.Available },
                new Car { Brand = CarBrand.Ford, Model = "Mustang GT", RentalPricePerDay = 70, Status = CarStatus.Available },
                new Car { Brand = CarBrand.Honda, Model = "Accord", RentalPricePerDay = 60, Status = CarStatus.Available },
                new Car { Brand = CarBrand.Mazda, Model = "3", RentalPricePerDay = 65, Status = CarStatus.Rented },
                new Car { Brand = CarBrand.BMW, Model = "6", RentalPricePerDay = 70, Status = CarStatus.Rented },
                new Car { Brand = CarBrand.Porsche, Model = "Boxster", RentalPricePerDay = 90, Status = CarStatus.Available }
            };

            cars.ForEach(c => context.Set<Car>().Add(c));
            context.SaveChanges();
        }
    }
}
