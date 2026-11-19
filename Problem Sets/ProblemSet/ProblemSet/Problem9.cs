using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet
{
    internal class Problem9
    {
        static void Main()
        {
            Console.Write(" What is your Age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Do You Have ID : \n press 1 for yes | press 2 for no : ");
            int Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            if ( age >= 18 && Id == 1)
            {
                Console.WriteLine(" Entry Allowed ");
            } else
            {
                Console.WriteLine("Entry Not Allowed");
            }

        }
    }
}
