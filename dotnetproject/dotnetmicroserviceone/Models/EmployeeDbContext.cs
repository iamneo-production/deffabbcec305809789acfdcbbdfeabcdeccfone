using Microsoft.EntityFrameworkCore;

public class EmployeeDbContext : EmployeeDbContext
{
    public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options): base(options)
    {

    }
    publicc DbSet<Employee> Employees { get; set;}
}