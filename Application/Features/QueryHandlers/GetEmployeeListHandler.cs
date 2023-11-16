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
    public class GetEmployeeListHandler : IRequestHandler<GetEmployeeListQuery, List<Employee>>
    {
        private readonly IEmployeeRepository _repository;

        public GetEmployeeListHandler(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Employee>> Handle(GetEmployeeListQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllEmployees();
        }
    }
}
