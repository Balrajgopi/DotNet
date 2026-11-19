using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLanguage
{
    internal class Building
    {
        static void Main ()
        {
            string[,] name = { { "x","y","z"}, {"a","b","c"}, {"d","e","f"} };
            int[,] member = { { 1,2,3},{4,5,6},{7,8,9}};

            int floors = 0;
            int Grand = 0;

            for (int i = 0; i < 3; i++)
            {
                floors = 0;

                for (int j = 0; j < 3; j++)
                {
                    floors += member[i, j];

                    Console.WriteLine($"{name[i, j]} has {member[i, j]} member");
                }

                Grand += floors;

                Console.WriteLine($"Total member in floor {i+1} is { floors}");

                Console.WriteLine("*********************");
            }
            Console.WriteLine($"Grand total member in the building is {Grand}");

        }
    }
}
