using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet
{
    internal class Problem11
    {
        static void Main ()
        {
            int var = 10;

            Console.WriteLine ($"Initial Variable Value : {var}");

            ++var;
            Console.WriteLine($"Variable after Pre-Increment : {var}");

            var++;
            Console.WriteLine($"Variable after Post-Increment : {var}");

            while (true)
            { 
                --var;
                Console.WriteLine($"Variable after Pre-Decrement : {var}");

                var--;
                Console.WriteLine($"Variable after Post-Decrement : {var}");

                break;
            }
        }
    }
}
