using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Collections.Generics;
using System.Linq;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController:ControllerBase
{
    private readonly EmployeeDbContext _context;

    public EmployeeController(EmployeeDbContext context)
    {
        _context =context;
    }
    [HttpGet]
    public async Task<ActionResult<IOrderedEnumerable<Employee>>>
    GetAllEmployees()
    {
        return await_context.Employee.ToListAsync();
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<Employee>>GetEmployeeById(int id)
    {
        var employee=await_context.FindAsync(id);
        if (employee==null)
        {
            return NotFount();
        }
        return employee;
    }
    [HttpPost]
    public async Task<ActionResult<Employee>>AddEmployee(Employee employee)
    {
        _context.Employees.Add(employee);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetEmployeeById),new{id=employee.EmployeeID},employee);
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult>DeleteEmployee(int id)
    {
        var employee=await _context.Employees.FindAsync(id);
        if(employee==null)
        {
            return NotFound();
        }
    }
}