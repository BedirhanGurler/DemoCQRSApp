using Domain.Entities.Concrete.Employee;
using Infrastructure.Context;
using Infrastructure.DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess.Concrete
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DemoDbContext _context;
        public EmployeeRepository(DemoDbContext context)
        {
            _context = context;
        }
        public async Task<Employee> AddNewEmployee(Employee employee)
        {
            using (var context = _context)
            {
                context.Employees.Add(employee);
               await context.SaveChangesAsync();
                return employee;
            }
        }

        public async Task<int> DeleteEmployee(int id)
        {
            var employeeToDelete = await _context.Employees.FindAsync(id);

            if (employeeToDelete != null)
            {
                _context.Employees.Remove(employeeToDelete);
                await _context.SaveChangesAsync();
            }

            return 1;
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            using(var context = _context)
            {
                var employees = context.Employees
                    .Where(e => e.IsActive == 1).ToListAsync();
                return await employees;
            }
        }

        public async Task<Employee> GetById(int id)
        {
            using( var context = _context)
            {
                return await context.Employees.Where(e => e.ID == id).FirstOrDefaultAsync();
            }
        }

        public async Task<int> UpdateEmployee(Employee employee)
        {
            using (var context = _context)
            {
                context.Employees.Update(employee);
                await context.SaveChangesAsync();
                return 1;
            }
        }

    }
}
