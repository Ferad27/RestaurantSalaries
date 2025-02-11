using RestaurantSalaries.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace RestaurantSalaries.Data
{
    public class RestaurantSalariesDbContext : IdentityDbContext<User>
    {
        public RestaurantSalariesDbContext(DbContextOptions<RestaurantSalariesDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Salary> Salaries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Salary>()
                .HasOne(s => s.Employee)
                .WithMany()
                .HasForeignKey(s => s.EmployeeId);
        }
    }
}