using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
     class TestEmp
    {
        internal static void Main ()
        {
          // // Employee e1 = new Employee { id = 1, name = "Balraj", Dept = "IT", Salary = 5000 };
          //  Employee E1 = new Employee(1, "Balraj", 5000, "IT");
          ////  Employee e2 = new Employee { id = 2, name = "Mohit", Dept = "IT", Salary = 15000 };

            //Manager and Sales class objects are created and initialized using object initializer syntax

          Manager M1 = new Manager { Id = 3, Name = "Rohit", Dept = "IT", Salary = 25000, Da = 5000, Hra = 2000 };
            //Manager M2 = new Manager(3, "Rohit", 25000, "IT", 5000, 2000);

          Sales S1 = new Sales { Id = 4, Name = "Kohit", Dept = "Sales", Salary = 14000, Commission = 3000, OT = 1000 };
            //Sales S2 = new Sales(4, "Rohit", 25000, "IT", 5000, 2000);

            //Console.WriteLine($"* Employee 1 : Id = {E1.Id}, Name = {E1.Name}, Department = {E1.Dept}, Salary = {E1.Salary}\n");

            ////Console.WriteLine($"* Employee 2  : Id = {e2.Id}, Name = {e2.name}, Department = {e2.dept}, Salary = {e2.Salary}\n");

            Console.WriteLine($"{M1.GetManagerDetails()}\n ");

            Console.WriteLine($"{S1.GetSalesDetails()}\n");

            Console.WriteLine($"{M1.CalculateSalary()} \n\n{S1.CalculateSalary()}");
        }
    }
}
