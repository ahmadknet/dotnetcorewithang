using dotnetcorewithang.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotnetcorewithang.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly DemoDBContext _db;
        public EmployeesController(DemoDBContext db)
        {
            _db = db;
        }

        // GET: EmployeesController
        public async Task<IActionResult> Index()
        {
            var employees =await _db.Employees.ToListAsync(); 
            return Ok(employees);
        }

        
    }
}
