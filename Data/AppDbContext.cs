using EmployeeMangment.Models; 
using Microsoft.EntityFrameworkCore;

namespace EmployeeMangment.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // DbSet for Employee model
        public required DbSet<Employee> Employees { get; set; }

        // Override OnModelCreating to customize model behavior (optional)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Add initial data for Employee table (seeding)
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "John Doe", Position = "Manager", Salary = 60000 },
                new Employee { Id = 2, Name = "Jane Smith", Position = "Developer", Salary = 50000 },
                new Employee { Id = 3, Name = "Alice Johnson", Position = "Designer", Salary = 55000 },
                new Employee { Id = 4, Name = "Bob Brown", Position = "Tester", Salary = 40000 },
                new Employee { Id = 5, Name = "Charlie Davis", Position = "Developer", Salary = 52000 },
                new Employee { Id = 6, Name = "David Lee", Position = "Manager", Salary = 65000 },
                new Employee { Id = 7, Name = "Eva Clark", Position = "Developer", Salary = 48000 },
                new Employee { Id = 8, Name = "Frank Moore", Position = "Sales", Salary = 45000 },
                new Employee { Id = 9, Name = "Grace Taylor", Position = "HR", Salary = 46000 },
                new Employee { Id = 10, Name = "Helen Harris", Position = "Support", Salary = 42000 }
            );
        }
    }
}

