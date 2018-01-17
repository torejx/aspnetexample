﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {

        [HttpPost("hello")]
        public IActionResult Hello([FromBody] Person person)
        {
            try
            {
                if (String.IsNullOrEmpty(person.Surname))
                {
                    throw new Exception("Surname is mandatory");
                }
                if (String.IsNullOrEmpty(person.Name))
                {
                    throw new Exception("Surname is mandatory");
                }
            }
            catch(Exception e)
            {
                return new BadRequestObjectResult(
                    new { error = e.Message}
                );
            }
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
