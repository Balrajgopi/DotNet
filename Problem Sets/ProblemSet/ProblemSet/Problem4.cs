using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet
{
    internal class Problem4
    {
        static void Main ()
        {
            Console.WriteLine("  * Area of Circle *");

            Console.WriteLine();

            Console.Write(" Enter the Radius : ");

            double radius = Convert.ToInt32(Console.ReadLine());

            double area = Math.PI * radius * radius;

            Console.WriteLine();

            Console.WriteLine(" * The Area Of The Circle With The Given Radius Is : " + area);





        }
    }
}
