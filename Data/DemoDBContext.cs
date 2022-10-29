using dotnetcorewithang.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetcorewithang.Data
{
    public class DemoDBContext : DbContext
    {

        public  DemoDBContext(DbContextOptions options) : base(options)            
        {   
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
