using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLanguage
{
    internal class DemojaggedArray
    {
        static void Main(string[] args)
        {
            string[] name = { "Tom", "Raj", "Sam" };
            int[][] marks = new int[3][];

            marks[0] = new int[] { 90, 80, 70 };
            marks[1] = new int[] { 60, 50, 40, 90, 80 };
            marks[2] = new int[] { 30, 10 };

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine($"Marks of {name[i]} are :");
                for (int j = 0; j < marks[i].Length; j++)
                {
                    Console.WriteLine(marks[i][j]);
                }

                Console.WriteLine("*********************");
            }
        }
    }
}
