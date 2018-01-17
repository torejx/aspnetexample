using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Example.Models;

namespace Example.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        [HttpPost("hello")]
        public IActionResult Hello([FromBody] Person person)
        {
            return Ok(person);
        }

        [HttpGet("hello/{name}/{surname}")]
        public string Hello(string name, string surname)
        {
            var person = new Person()
            {
                Name = name,
                Surname = surname
            };
            return $"Hello {person.Name} {person.Surname}, or if you prefer {person.Signature}";
        }
    }
}
