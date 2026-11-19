using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLanguage
{
    internal class DemoMultiArray
    {
        static void Main (string[] args)
        {
            //int[,] num = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($" |{nums[j, i]}| ");

            //    }
            //}
            //Console.WriteLine();


            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        string sum;
            //        Console.WriteLine($"{num[i,j]} {i + j}");
            //        sum = num[i] + sum[j];
            //        Console.WriteLine(sum);

            //    }
            //}


                        //ISSUE

            //int[,] num = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            //for (int r = 0; r < num.GetLength(0); r++) 
            //{
            //    int s = 0;
                
            //    for (int c = 0; c < num.GetLength(1); c++)
            //    {
            //        s += num[r, c];
            //        Console.WriteLine($"Row {r} : {s}");
            //    }

            //    for (int c =0; c < num.GetLength(1); c++)
            //    {
            //        int s = 0;
            //        for (int r = 0; r < num.GetLength(8); r++)
            //        {
            //            s += num[r, c];
            //            Console.WriteLine($" Column {c} : {s}");
            //        }
            //    }
            //}

            int[,] num = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            // Calculate and print row sums
            for (int r = 0; r < num.GetLength(0); r++)
            {
                int s = 0;
                for (int c = 0; c < num.GetLength(1); c++)
                {
                    s += num[r, c];
                }
                Console.WriteLine($"Row {r} : {s}");
            }

            // Calculate and print column sums
            for (int c = 0; c < num.GetLength(1); c++)
            {
                int s = 0;
                for (int r = 0; r < num.GetLength(0); r++)
                {
                    s += num[r, c];
                }
                Console.WriteLine($"Column {c} : {s}");
            }

        }
    }
}
