using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Mike";
            person.Age = 20;
            person.GetNameAndAge();

            Person.Teacher teacher = new Person.Teacher();
            teacher.Name = "Thomas ";
            teacher.Age = 35;
            teacher.TeacherId = "190302";
            teacher.Subject = "Math";
            teacher.GetNameAndAge();

            Person.Student student = new Person.Student();
            student.Name = "Sara";
            student.Age = 19;
            student.StudentId = "10506";
            student.Email = "sara1234@amikom.ac.id";
            student.GetNameAndAge();


            Console.ReadKey();
        }
    }
}