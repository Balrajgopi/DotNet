using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblemSet
{
    internal class Problem1
    {
        static void Main ()
        {
            Console.WriteLine();
            int[] marks = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            Console.WriteLine("* Using For Loop *");
            Console.WriteLine();
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine($"The Elements Isn marks Uing For Loop Are : {marks[i]}");
            }
            Console.WriteLine();    
            Console.WriteLine("* Using ForEach Loop *");
            Console.WriteLine();
            foreach (int s in marks)
            {
                Console.WriteLine($"The Elements In marks Using ForEach Loop are : {s}");
            }
        }
    }
}
