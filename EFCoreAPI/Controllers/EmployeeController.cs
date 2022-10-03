using EFCoreAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCoreAPI.Controllers
{
    public class Emp
    {
        [Required]
        public string Name { get; set; }
    }
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Employee/GetEmployees")]
        public IEnumerable<Employee> GetEmployees()
        {
            return _employeeService.GetEmployees();
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Employee/GetGuid")]
        public string GetGuid()
        {
            return _employeeService.GetGuid();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Employee/Show")]
        public string Show([FromBody] Emp emp)
        {
            if (ModelState.IsValid)
            {

            }
            return emp.Name;
        }
    }
}
