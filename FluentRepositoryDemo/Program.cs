
using FluentRepositoryDemo.Models;
using FluentRepositoryDemo.Repositories;
using System.Collections.Generic;
namespace FluentRepositoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var repository = new CarRepository())
            {
                List<Car> result1 = repository.Query()
                                        .IsAvailable()
                                        .WithMinimumPriceOf(70);

                List<Car> result2 = repository.Query()
                                        .IsBMW()
                                        .IsAvailable()
                                        .WithMinimumPriceOf(60)
                                        .WithMaximumPriceOf(80);
            }
        }
    }
}
