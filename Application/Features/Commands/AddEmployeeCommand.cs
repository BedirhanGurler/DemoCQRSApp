using Domain.Entities.Concrete.Employee;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Commands
{
    public class AddEmployeeCommand: IRequest<Employee>
    {
        public string EmployeeFullName { get; set; }
        public string EmployeeTitle { get; set; }
        public string EmployeeDepartment { get; set; }
        public string EmployeeEmail { get; set; }
        public int IsActive { get; set; }

        public AddEmployeeCommand()
        {
        }

        public AddEmployeeCommand(string employeeFullName, string employeeTitle, string employeeDepartment, string employeeEmail, int ısActive)
        {
            EmployeeFullName = employeeFullName;
            EmployeeTitle = employeeTitle;
            EmployeeDepartment = employeeDepartment;
            EmployeeEmail = employeeEmail;
            IsActive = ısActive;
        }

      
    }
}
