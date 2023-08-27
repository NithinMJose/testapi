using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApi.Data;
using MyApi.Models;

namespace MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private  EmployeeContext _employee;
        public EmployeeController(EmployeeContext employee)
        {
            _employee = employee;
        }

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var employees = _employee.Employees;
            return Ok(employees);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = _employee.Employees.Find(id);
            return Ok(employee);
        }
        [HttpPost]
        public IActionResult Post(Employee employee)
        {
           _employee.Employees.Add(employee);
            _employee.SaveChanges();
            return Ok(employee);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Put()
        {
            return NoContent();
        }

    }
}
