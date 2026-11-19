using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet
{
    internal class Problem2
    {
        static void Main()
        {
          void Maths (int a = 6, int b = 5 )
            {
                int add = a + b;
                int sub = a - b;
                int mul = a * b;
                int div = a / b;
                int mod = a % b;
                Console.WriteLine("A is 6 and B is 5");
                Console.Write($"* Addition : {add}   * Subtraction : {sub}   * Multiplication = {mul}   ");
                Console.WriteLine($"* Division : {0}  * Module : {1}", div, mod);
            }

            Maths();


        }
    }
}
