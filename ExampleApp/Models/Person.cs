using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Person
    {
        [Required(ErrorMessage = "{0} is mandatory")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} is mandatory")]
        public string Surname { get; set; }

        public string Signature
        {
            get {
                return Name[0] + ". " + Surname;
            }
        }
       
        public Person()
        {

        }
    }
}
