using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NetFrameWorkWebAPI.Models;

namespace NetFrameWorkWebAPI.Repositories
{
    public class EmployeeRepository:Repository<Employee>
    {
        private EmployeesEntities employeesEntities;
        public EmployeeRepository(EmployeesEntities employeesEntities):base(employeesEntities)
        {
            this.employeesEntities = employeesEntities;
        }
        public IEnumerable<Employee> GetUsuarios()
        {
            return employeesEntities.Employee.OrderBy(x=>x.ID);
        }


    }
}