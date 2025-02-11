using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace RestaurantSalaries.Data
{
    public class RestaurantSalariesDbContextFactory : IDesignTimeDbContextFactory<RestaurantSalariesDbContext>
    {
        public RestaurantSalariesDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<RestaurantSalariesDbContext>();
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-GMT00QS\MSSQLSERVER2022;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;Database=RestaurantDB;Trusted_Connection=True;");
    
            return new RestaurantSalariesDbContext(optionsBuilder.Options);
        }
    }
}
