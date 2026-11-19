using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DemoLanguage
{
    internal class ArrayDemo
    {
        static void Main (String[] args)
        {
            // int[] numbers = { 1, 2, 3, 4, 5 };
            //int[] numbers2 = new int[5];

            /*   int Total = 0;
               for (int i = 0; i < numbers.Length; i++)
               {
                   Console.WriteLine(numbers[i]);
                    Total += numbers[i];
               }
               Console.WriteLine(Total);

               for (int i = 4 ; i < numbers.Length; i--)
               {
                   Console.WriteLine(numbers[i]);
                   //Total += numbers[i];
               }
            */

            //for (int i =0; i < numbers2.Length; i++)
            //{
            //    Console.WriteLine("Enter Numbers : " + (i + 1));
            //    numbers2[i] = Convert.ToInt32(Console.ReadLine());

            //    //Console.WriteLine(numbers2[i]);
            //}
            //foreach (int n in numbers2) //for printing the array
            //{
            //    Console.WriteLine(n);
            //}


            //string[] name = { "Balraj", "mohit", "rupesh", "bhavarlal" };

            //foreach (string n in name)
            //{
            //    Console.WriteLine(n);
            //}

            //int[] nums = { 10, 20, 30, 40, 50 };

            //for (int i = 0, j = nums.Length - 1; i < j; i++, j--)
            //{
            //    int temp = nums[i];
            //    nums[i] = nums[j];
            //    nums[j] = temp;
            //}
            //for (int l = 0; l < nums.Length; l++)
            //{
            //    Console.WriteLine(nums[l]);
            //}

            // Sorting Array

            //int[] num = { 20, 10, 80, 60, 40, 50, 70, };

            //for (int i = 0; i < num.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < num.Length; j++)
            //    {
            //        if (num[i] > num[j])
            //        {
            //            int temp = num[i];
            //            num[i] = num[j];
            //            num[j] = temp;

            //        }
            //    }
            //}

            //// Printing Array

            //for (int n = 0; n < num.Length; n++)
            //{
            //    Console.WriteLine(num[n]);

            //}

            //string[] name = { "Balraj", "Rupesh", "Bhavarlal", "Mohit" };

            //int[] Salary = { 5000, 10000, 20000, 30000 };

            //for (int i = 0; i < name.Length -1; i++)
            //{
            //    for (int j = i + 1; j < name.Length; j++)
            //    {
            //        if (name[i].CompareTo(name[j]) > 0)
            //        {
            //            int temp = Salary[i];
            //            Salary[i] = Salary[j];
            //            Salary[j] = temp;

            //            string tempname = name[i];
            //            name[i] = name[j];
            //            name[j] = tempname;

            //        }


            //    }

            //}

            //for (int n = 0; n < name.Length; n++)
            //{
            //    Console.WriteLine($"{name[n]} : {Salary[n]}");
            //}

            int[] nums = { 1, 2, 3, 4, 5, 6, 6, 7, 8, 7, 90, 9 };

            int n = 6;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == n)
                {
                    Console.WriteLine($"Number {n} Found at Index :{i} " );
                    break;
                }

                if (i == nums.Length -1)
                {
                    Console.WriteLine($"Number {n} Not Found");
                }
            }






             
        }
    }
}
