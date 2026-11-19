using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet
{
    internal class Problem5
    {
        static void Main()
        {
            int a = 5, b = 6;

            Console.WriteLine();
            //Console.Write($"     * Before Swap : {a} {b} ");

            Console.WriteLine("     * Before Swap : A = {0}  B = {1}", a,b);

            int c = a;
                a = b;
                b = c;

            Console.WriteLine();

            Console.Write("     * After Swap : ");
            Console.WriteLine(" A = {0}  B = {1}", a,b);



        }
    }
}
