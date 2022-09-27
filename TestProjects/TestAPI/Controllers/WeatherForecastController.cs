using Microsoft.AspNetCore.Mvc;

namespace TestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {        
        [HttpGet]
        public string Get()
        {
            //throw new Exception("Test hatasi");
            return "OK";
        }

        [HttpGet("Student")]
        public Student GetStudent()
        {
            return new Student()
            {
                Id = 1,
                Name = "Emre"
            };
        }

        [HttpPost("Student")]
        public Student CreateStudent([FromBody] Student student)
        {

            return student;
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}