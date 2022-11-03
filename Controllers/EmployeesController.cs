using dotnetcorewithang.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotnetcorewithang.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly DemoDBContext _db;
        public EmployeesController(DemoDBContext db)
        {
            _db = db;
        }


        // GET: EmployeesController
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var employees = await _db.Employees.ToListAsync();
            return Ok(employees);
        }
    }
}


//// GET: EmployeesController
//public IEnumerable<Employee> Get()
//{
//    var employees = _db.Employees.ToList();
//    return employees;
//    //return Ok(employees);
//}