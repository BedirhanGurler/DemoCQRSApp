using Domain.Entities.Concrete.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess.Abstract
{
    public interface IEmployeeRepository
    {
        public Task<List<Employee>> GetAllEmployees();
        public Task<Employee> GetById(int id);
        public Task<Employee> AddNewEmployee(Employee employee);
        public Task<int> UpdateEmployee(Employee employee);
        public Task<int> DeleteEmployee(int id);
        
    }
}
