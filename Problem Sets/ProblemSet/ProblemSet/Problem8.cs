using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet
{
    internal class Problem8
    {
        static void Main()
        {
            Console.WriteLine("* Enter Two Value To Check Whether It Is Equal, Less than or More Than ");
            Console.WriteLine();

            Console.Write("Enter One Int value : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Int value : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if (a < b)
            {
                Console.WriteLine(" A is Lesser Than B ");
            }
            else if ( a > b )
            {
                Console.WriteLine("A is Greater Than B");
            }
            else
             {
                Console.WriteLine("A and B Both are Equal");
            }

        }
        
    }
}
