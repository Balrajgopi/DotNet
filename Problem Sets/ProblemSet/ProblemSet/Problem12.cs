using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet
{
    internal class Problem12
    {
        static void Main ()
        {
            Console.Write("* Enter Integer Value To Find Out Even Or Odd : ");
            int i = Convert.ToInt32(Console.ReadLine());

            if ( i % 2 == 0)
            {
                Console.WriteLine($" {i} Is A Even Number");
            }
            else
            {
                Console.WriteLine($"{i} Is A Odd Number");
            }
        }
    }
}
