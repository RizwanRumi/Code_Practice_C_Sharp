using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Rizwan",
                    Department = Dept.IT,
                    Email = "rizwan@gmail.com"
                },
                new Employee
                {
                    Id = 2,
                    Name = "Rumi",
                    Department = Dept.IT,
                    Email = "rumi@gmail.com"
                }
            );
        }
    }
}
