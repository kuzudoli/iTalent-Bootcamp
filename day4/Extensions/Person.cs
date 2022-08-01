using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4.Extensions
{
    internal class Person
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }

    }

    internal class PersonDto
    {
        public string fullname { get; set; }
        public int age { get; set; }

    }
}
