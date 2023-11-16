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
    public class DeleteEmployeeHandler : IRequestHandler<DeleteEmployeeCommand, int>
    {
        private readonly IEmployeeRepository _repository;

        public DeleteEmployeeHandler(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _repository.GetById(request.ID);
            if (employee == null)
                return default;
            return await _repository.DeleteEmployee(employee.ID);
        }
    }
}
