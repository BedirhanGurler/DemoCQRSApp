using Domain.Entities.Concrete.Employee;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Context
{
    public class DemoDbContext : DbContext
    {
       protected readonly IConfiguration Configuration;
       public DemoDbContext(IConfiguration configuration)
       {
            Configuration = configuration;
       }
       protected override void OnConfiguring(DbContextOptionsBuilder options)
       {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
       }

        public DbSet<Employee> Employees { get; set; }
    }
}
