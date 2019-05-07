using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void GetNameAndAge()
        {
            Console.WriteLine("The person has name : {0} and age {1}", Name, Age);
        }

        public class Teacher : Person
        {
            public string TeacherId { get; set; }
            public string Subject { get; set; }
        }

        public class Student : Person
        {
            public string StudentId { get; set; }
            public string Email { get; set; }
        }


    }

}
