using Application.Features.Commands;
using Application.Features.Queries;
using Domain.Entities.Concrete.Employee;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/empolyee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator mediator;

        public EmployeeController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("/get-all")]
        public async Task<List<Employee>> GetAll()
        {
            var employee = await mediator.Send(new GetEmployeeListQuery());
            return employee;
        }

        [HttpPost("/add-new")]
        public async Task<Employee> AddNew(Employee employee)
        {
            var employees = await mediator.Send(new AddEmployeeCommand(
                employee.EmployeeFullName,
                employee.EmployeeTitle,
                employee.EmployeeDepartment,
                employee.EmployeeEmail,
                employee.IsActive));
            return employees;
        }
    }
}
