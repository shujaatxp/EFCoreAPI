using System.Collections.Generic;

namespace EFCoreAPI.Model
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();

        public string GetGuid();
    }
}
