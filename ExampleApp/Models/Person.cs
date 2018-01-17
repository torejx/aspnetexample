using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Person
    {
        public string Name { get; set; }
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
