using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Context
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>contextOptions)
            : base(contextOptions)
        {
            
        }

        //
        public DbSet<Employee>Employees { get; set; }
    }
}
