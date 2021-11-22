using AngularCrud2.Models;
using Microsoft.EntityFrameworkCore;

namespace AngularCrud2.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> GetEmployees { get; set; }
    }
}
