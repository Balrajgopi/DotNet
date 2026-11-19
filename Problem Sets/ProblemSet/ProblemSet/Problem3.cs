using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet
{
    internal class Problem3
    {
        static void Main()
        {
            string x = "21";

            int age = int.Parse(x);

            Console.WriteLine($" * The Person Current Age is {x}");

            //x = "abc";
            Console.WriteLine();

            int z = 12;

            bool y = int.TryParse(x, out z);

            Console.WriteLine($" * The Convertion of String to Int IS : "+y);

            Console.WriteLine();

            Console.WriteLine($" * The Age of the Person After 5 Year Will Be : {age + 5}");
        }
    }

}
