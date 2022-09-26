using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreAPI.Model
{
    public class EmployeeService : IEmployeeService
    {
        public EmployeeContext _employeeDbContext;
        public EmployeeService(EmployeeContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }
        public List<Employee> GetEmployees()
        {
            return _employeeDbContext.Employees.ToList();
        }

        public string GetGuid()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
