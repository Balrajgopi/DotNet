using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet
{
    internal class Problem7
    {
        static void Main()
        {
            Console.WriteLine(" * Enter Three Intger's Number *");

            Console.WriteLine();

            Console.Write("Enter Value fron A : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Value fron B : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Value fron C : ");
            int c = Convert.ToInt32(Console.ReadLine());

            int sum = a + b * c;

            int sum1 = (a + b) * c;
            Console.WriteLine();

            Console.WriteLine($"-> A + B * C = {sum}");

            Console.WriteLine();

            Console.WriteLine($"-> (A + B) * C = {sum1}");



        }
    }
}
