using RestaurantSalaries.Data;
using RestaurantSalaries.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace RestaurantSalaries
{
    internal static class Program
    {        
        [STAThread] // The main entry point for the Application.
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            services.AddDbContext<RestaurantSalariesDbContext>(options =>
                options.UseSqlServer(@"Server=DESKTOP-GMT00QS\MSSQLSERVER2022;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;Database=RestaurantDB;Trusted_Connection=True;"));

            var serviceProvider = services.BuildServiceProvider();
            var dbContext = serviceProvider.GetRequiredService<RestaurantSalariesDbContext>();

            ApplicationConfiguration.Initialize();
            var restaurantService = new RestaurantService(dbContext);
            Application.Run(new LoginForm(dbContext));
        }
    }
}