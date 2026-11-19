using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLanguage
{
    internal class DataInput
    {
        static void Main() 
        {
            string name;
            int salary;
            int bonus;

            Console.Write(" * Enter Name : ");
            name = Console.ReadLine();

            Console.Write(" * Enter Your Salary : ");
            salary = Convert.ToInt32(Console.ReadLine());

            bonus = salary * 10 / 100;

            Console.WriteLine($" * Name = {name}   * Salary = {salary:C}  * Bonus = {bonus}");

        }
    }
}
