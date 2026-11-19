using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLanguage
{
    internal class Test1
    {
        static void Main ()
        {
            Console.WriteLine("This is Class Test");

            Console.WriteLine();

            // For Loop 

            Console.WriteLine(" * For Loop *");

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("For Loop Iteration : "+i);
            }

            Console.WriteLine();

            // While Loop

            Console.WriteLine(" * While Loop *");

            int A = 0;

            while (A < 5) 
            {
                Console.WriteLine("While loop Iteration : "+A );
                A++;
            }

            Console.WriteLine();
            /* Do 
                 While
                      Loop */
            Console.WriteLine(" * Do While Loop *");
            int B = 0;

            do
            {
                Console.WriteLine("Do While Loop Iteration :"+B);
                B++;
            } while (B < 5);

            Console.WriteLine();
            Console.WriteLine("Nullable Data Type");
            Console.WriteLine();
            int? x = null;
            Nullable<int> y = null;

            if (x.HasValue)
            {
                Console.WriteLine($"X has Value : {x.Value}");
            }
            else
            {
                Console.WriteLine("X is null");

            }
        }
    }
}
