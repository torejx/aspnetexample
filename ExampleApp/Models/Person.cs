using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Person
    {
        private string _name;
        private string _surname;

        public string Name
        {
            get {
                return _name;
            }
            set {
                _name = value;
            }
        }

        public string Surname
        {
            get => _surname;
            set => _surname = value;
        }

        public Person()
        {

        }
    }
}
