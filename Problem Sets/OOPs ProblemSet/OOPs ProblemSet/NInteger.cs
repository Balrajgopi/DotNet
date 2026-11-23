using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_ProblemSet
{
    internal class NInteger
    {
        static void Main(string[]args)
        {
            int Max;

            Console.Write("Enter How Many Numbers Of Arr Required : ");
            Max = Convert.ToInt32(Console.ReadLine());

            int[] Arr = new int[Max];

            foreach (int  n in Arr)
            {
                Console.Write($" Enter Value for Array Index {Arr[n]+1} : ");
                    Arr[n] = Convert.ToInt32(Console.ReadLine());
            }

            int Sum = 0;

            for (int i = 0; i < Arr.Length; i++)
            {
                Sum = Sum + i;
            }

            Console.WriteLine($"The Sum Of the Array is : {Sum}");

            //foreach (int i in Arr)
            //{
            //   // Console.WriteLine($"The Sum Of the Array is : {Sum+i}");
            //    
            //}

            Console.WriteLine($"The Average Of The Array is {Sum / 2}");
        }
    }
}
