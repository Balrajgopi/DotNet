using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet
{
    internal class Problem6
    {
        static void Main ()
        {
            Console.WriteLine();

            string name;
            Console.Write("-> Enter the Name of the Employee : ");
             name =   Console.ReadLine();

            Console.Write("-> Enter the Employee ID : ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("-> Enter the Montly Salary of the Employee : ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("     * Details of the Employees *");

            Console.WriteLine();

            double AnnualSalary = salary * 12;

            Console.WriteLine($"* The Employee Name Is : {name} \n" +
                $"* The Employee ID is : {id}\n" +
                $"* The Annual Salary Of The Employee is : {AnnualSalary}");


        }
    }
}
