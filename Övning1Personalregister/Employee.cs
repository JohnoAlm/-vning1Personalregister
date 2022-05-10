using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning1Personalregister
{
    internal class Employee
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }

        //public Employee(string firstName, string lastName, int salary)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Salary = salary;
        //}

        public void DisplayEmployee()
        {
            Console.WriteLine("Namn: " + FirstName + " " + LastName + "\n" + "Lön: " + Salary + "kr");
        }
        

    }
}
