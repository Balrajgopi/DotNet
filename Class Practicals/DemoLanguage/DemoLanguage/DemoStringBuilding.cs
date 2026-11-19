using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLanguage
{
    internal class DemoStringBuilding
    {
        static void Main ()
        {
            StringBuilder sb = new StringBuilder("HELLO WORLD");
            Console.WriteLine(sb);

            sb.Append("......");
            Console.WriteLine(sb.ToString());

            sb.Insert(5, ",");
            Console.WriteLine(sb.ToString());

            sb.Replace("WORLD", "GUYS");
            Console.WriteLine(sb.ToString());

            sb.Remove(5, 1);
            Console.WriteLine(sb.ToString());

        }
    }
}
