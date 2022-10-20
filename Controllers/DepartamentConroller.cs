using EmploedServes.Models.Request;
using EmploedServes.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmploedServes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentConroller : ControllerBase
    {
        private readonly IDepartmentRepository departmentRepository;

        public DepartamentConroller(IDepartmentRepository departmentRepository)
        {
            this.departmentRepository = departmentRepository;
        }

        public IActionResult Create([FromBody] CreateDepartmentRequest reqyest)
        {
            return Ok(departmentRepository.Create(new Models.Departament
            {
                
                Description= reqyest.Description

            }));

        }

        [HttpGet("get/all")]
        public IActionResult GetAllEmployees()
        {
            return Ok(departmentRepository.GetAll());
        }
        [HttpGet("get/{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            return Ok(departmentRepository.GetAll());
        }
    }
}
