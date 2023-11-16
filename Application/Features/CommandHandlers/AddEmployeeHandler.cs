using Application.Features.Commands;
using Domain.Entities.Concrete.Employee;
using Infrastructure.DataAccess.Abstract;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CommandHandlers
{
    public class AddEmployeeHandler : IRequestHandler<AddEmployeeCommand, Employee>
    {
        private readonly IEmployeeRepository _repository;

        public AddEmployeeHandler(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public async Task<Employee> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = new Employee()
            {
                EmployeeFullName = request.EmployeeFullName,
                EmployeeEmail = request.EmployeeEmail,
                EmployeeTitle = request.EmployeeTitle,
                EmployeeDepartment = request.EmployeeDepartment,
                IsActive = request.IsActive
            };
            return await _repository.AddNewEmployee(employee);
        }
    }
}
