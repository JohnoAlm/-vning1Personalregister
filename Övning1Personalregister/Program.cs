using System;

namespace Övning1Personalregister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            string firstname, lastname;
            int salary;


            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Mata in förnamn:");
                firstname = Console.ReadLine();

                Console.WriteLine("Mata in efternamn");
                lastname = Console.ReadLine();

                Console.WriteLine("Mata in lön:");
                salary = Convert.ToInt32(Console.ReadLine());

                list.Add(new Employee
                {
                    FirstName = firstname,
                    LastName = lastname,
                    Salary = salary
                });
            }

            Console.WriteLine("\n");
            Console.WriteLine("Personalregister:");
            Console.WriteLine("____________________");
            Console.WriteLine("\n");


            foreach(Employee employee in list)
            {
                employee.DisplayEmployee();
            }

            Console.ReadLine();


            
                
            

            
            

            

        }
    }
}
