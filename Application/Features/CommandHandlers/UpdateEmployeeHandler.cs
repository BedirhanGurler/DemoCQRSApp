using Application.Features.Commands;
using Infrastructure.DataAccess.Abstract;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.CommandHandlers
{
    public class UpdateEmployeeHandler : IRequestHandler<UpdateEmployeeCommand, int>
    {
        private readonly IEmployeeRepository _repository;

        public UpdateEmployeeHandler(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _repository.GetById(request.ID);
            if (employee == null)
                return default;

            employee.EmployeeFullName = request.EmployeeFullName;
            employee.EmployeeTitle = request.EmployeeTitle;
            employee.EmployeeDepartment = request.EmployeeDepartment;
            employee.EmployeeEmail = request.EmployeeEmail;
            employee.IsActive = request.IsActive;

            // UpdateEmployee metodunu çağırın ve dönüş değerini doğrudan döndürün
            return await _repository.UpdateEmployee(employee);
        }
    }
}
