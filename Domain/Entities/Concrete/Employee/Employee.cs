using Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Concrete.Employee
{
    public class Employee : IEntity
    {
        public int ID { get; set; }
        public string EmployeeFullName { get; set; }
        public string EmployeeTitle { get; set; }
        public string EmployeeDepartment { get; set; }
        public string EmployeeEmail { get; set; }
        public int IsActive { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
    }
}
