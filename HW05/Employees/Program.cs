// Written by James Jang
// 02/24/2025

namespace Employees
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Manager aManager = new Manager("Frank", 250000, 8);
            Engineer aEngineer = new Engineer("Bob", 220000, "Embedded Systems");
            List<Employee> aListOfEmployees = new List<Employee>() { aManager, aEngineer };
            foreach (Employee e in aListOfEmployees)
            {
               Console.WriteLine(e);
            }
        }
    }
}
