using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Commands
{
    public class DeleteEmployeeCommand: IRequest<int>
    {
        public int ID { get; set; }
    }
}
