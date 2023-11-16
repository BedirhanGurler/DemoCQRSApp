using Application.Features.Queries;
using Domain.Entities.Concrete.Employee;
using Infrastructure.DataAccess.Abstract;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.QueryHandlers
{
    public class GetEmployeeByIdHandler : IRequestHandler<GetEmployeeByIdQuery, Employee>
    {
        private readonly IEmployeeRepository _repository;

        public GetEmployeeByIdHandler(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public async Task<Employee> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetById(request.ID);
        }
    }
}
