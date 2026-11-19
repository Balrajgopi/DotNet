using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
    internal class TestEmp
    {
        static void Main ()
        {
            employee e1 = new employee { Id = 1, name = "Balraj", dept = "IT", Salary = 5000 };
            employee e2 = new employee { name = "Mohit", dept = "IT", Salary = 15000 };

            Console.WriteLine($"Employee 1 : Id = {e1.Id}, Name = {e1.name}, Department = {e1.dept}, Salary = {e1.Salary}");

            Console.WriteLine($"Employee 1 : Id = {e2.Id}, Name = {e2.name}, Department = {e2.dept}, Salary = {e2.Salary}");
        }
    }
}
