using EmploedServes.Models.Request;
using EmploedServes.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmploedServes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeedController : ControllerBase
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeedController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        [HttpPost("create")]

        public IActionResult Create([FromBody]CreateEmployeeRequest reqyest)
        {
            return Ok(employeeRepository.Create(new Models.Employee
            {
                DepartmentId = reqyest.DepartmentId,
                EmployeeTypeId = reqyest.EmployeeTypeId,
                FirstName = reqyest.FirstName,
                Patronymic = reqyest.Patronymic,
                Salary = reqyest.Salary,
                Surname = reqyest.Surname

            }));

        }

        [HttpGet("get/all")]
        public IActionResult GetAllEmployees()
        {
            return Ok(employeeRepository.GetAll());
        }
        [HttpGet("get/{id}")]
        public IActionResult GetById([FromRoute]int id)
        {
            return Ok(employeeRepository.GetAll());
        }
    }

}
