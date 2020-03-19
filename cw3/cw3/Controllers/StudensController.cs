using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw3.DAL;
using cw3.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace cw3.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudensController : ControllerBase
    {

        private readonly IDbService _dbService;

        public StudensController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        public IActionResult getStudents(string orderBy)
        {
            return Ok(_dbService.GetStudents());
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            student.IndexNumber = $"s{new Random().Next(1, 2000)}";
            return Ok(student);
        }

        [HttpPut("{id}")]
        public IActionResult PutStudent(int id)
        {
            return Ok("aktualizacja dokonczona");
        }
        
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            return Ok("usuwanie dokonczone");
        }

    }
}
