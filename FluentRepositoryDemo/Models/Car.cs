
namespace FluentRepositoryDemo.Models
{
    public class Car
    {
        public int Id { get; set; }
        public CarBrand Brand { get; set; }
        public string Model { get; set; }
        public decimal RentalPricePerDay { get; set; }
        public CarStatus Status { get; set; }
    }
}
