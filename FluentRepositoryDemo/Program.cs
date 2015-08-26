
using FluentRepositoryDemo.Models;
using FluentRepositoryDemo.Repositories;
using System;
using System.Collections.Generic;
namespace FluentRepositoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var repository = new CarRepository())
            {
                List<Car> availableCarsWithMinPrice70
                            = repository.Query()
                                        .IsAvailable()
                                        .WithMinimumPriceOf(70);

                PrintResult("Available cars with minimum price of 70", availableCarsWithMinPrice70);

                List<Car> availableBMWWithPriceBetween60And80
                            = repository.Query()
                                        .IsBMW()
                                        .IsAvailable()
                                        .WithMinimumPriceOf(60)
                                        .WithMaximumPriceOf(80);

                PrintResult("Available BMW cars with minimum price of 60 and maximum price of 80", availableBMWWithPriceBetween60And80);
            }
        }

        private static void PrintResult(string title, List<Car> result)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(title);
            Console.ResetColor();

            result.ForEach(r => Console.WriteLine("- Brand: {0}, Model: {1}, Price: {2}, Status: {3}", 
                r.Brand, r.Model, r.RentalPricePerDay, r.Status));

            Console.WriteLine();
        }
    }
}
