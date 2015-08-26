using FluentRepositoryDemo.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace FluentRepositoryDemo.Repositories.Mapping
{
    public class CarMap : EntityTypeConfiguration<Car> 
    {
        public CarMap()
        {
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
