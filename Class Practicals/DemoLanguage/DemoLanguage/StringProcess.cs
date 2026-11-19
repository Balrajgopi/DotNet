using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLanguage
{
    internal class StringProcess
    {
        static void Main ()
        {
            string msg = "Today is wednesday and 18th Nov 2026";

            Console.WriteLine ();

            int Length = msg.Length;
            Console.WriteLine($"Length Of The Message is : {msg}");

            Console.WriteLine();

            string upper = msg.ToUpper();
            Console.WriteLine($"UpperCase String are : {upper}");

            Console.WriteLine();

            string lower = msg.ToLower();
            Console.WriteLine($"Lowercase String are : {lower}");

            int acount = 0;
            int ecount = 0;
            int icount = 0;
            int ocount = 0;
            int ucount = 0;
            int uppercount = 0;
            int lowercount = 0;


            foreach (char c in msg)
            {
                Console.WriteLine(c);

                if (char.IsUpper(c))
                {
                    uppercount++;
                }
                else if (char.IsLower(c))
                {
                    lowercount++;

                }
                
                switch (c)
                {
                    case 'a':
                    case 'A':
                        acount++;
                        break;
                    case 'e':
                    case 'E':
                        ecount++;
                        break;
                    case 'i':
                    case 'I':
                        icount++;
                        break;
                    case 'o':
                    case 'O':
                        ocount++;
                        break;
                    case 'u':
                    case 'U':
                        ucount++;
                        break;



                }
            }
            Console.WriteLine($"Number of 'a' Or 'A' Characters : {acount}");
            Console.WriteLine($"Number Of 'e' Or 'E' Characters : {ecount}");
            Console.WriteLine($"Number Of 'i' Or 'I' Characters : {icount}");
            Console.WriteLine($"Number OF 'o' Or 'O' Characters : {ocount}");
            Console.WriteLine($"Number Of 'u' Or 'U' Characters : {ucount}");
            Console.WriteLine($"Number Of UpperCase Characters : {uppercount}");
            Console.WriteLine($"Number Of LowCrase Characters : {lowercount}");
        }       
    }
}
