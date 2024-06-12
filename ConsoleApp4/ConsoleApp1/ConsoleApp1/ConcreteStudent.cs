using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ConcreteStudent : Student
    {
        public ConcreteStudent(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override void Display()
        {
            Console.WriteLine($"Студент: {FirstName} {LastName}");
        }
    }
}
