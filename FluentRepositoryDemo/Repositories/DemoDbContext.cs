using FluentRepositoryDemo.Repositories.Mapping;
using System.Data.Entity;

namespace FluentRepositoryDemo.Repositories
{
    public class DemoDbContext : DbContext
    {
        static DemoDbContext()
        {
            Database.SetInitializer<DemoDbContext>(null);
        }

        public DemoDbContext()
        {
            base.Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CarMap());
        }
    }
}
