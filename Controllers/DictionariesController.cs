using EmploedServes.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmploedServes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DictionariesController : ControllerBase
    {
        private readonly IEmployeeTypeRepository employeeTypeRepository;

        public DictionariesController(IEmployeeTypeRepository employeeTypeRepository)
        {
            this.employeeTypeRepository = employeeTypeRepository;
        }

        [HttpGet("employee-types/all")]
        public IActionResult GetAllEmployeeTypes()
        {
            return Ok(employeeTypeRepository.GetAll());
        }
    }
}
