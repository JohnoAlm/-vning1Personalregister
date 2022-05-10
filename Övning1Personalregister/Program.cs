using System;

namespace Övning1Personalregister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 11; i++)
            {
            Employee employee = new Employee();
            
            
            Console.WriteLine("Mata in förnamn:");
            employee.FirstName = Console.ReadLine();
            Console.WriteLine("Mata in efternamn");
            employee.LastName = Console.ReadLine();
            Console.WriteLine("Mata in lön:");
            employee.Salary = Convert.ToInt32(Console.ReadLine());

            employee.DisplayEmployee();
            }

                
            

            
            

            

        }
    }
}
