using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Collections.Generics;
using System.Linq;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController:ControllerBase
{
    private readonly EmployeeDbContext_context;

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
        var employee=await_context.F
    }
}