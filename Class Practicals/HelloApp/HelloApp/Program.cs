using System.Diagnostics;

using Greetings;
using Calc;
namespace HelloApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Greet greet = new Greet();
            Console.WriteLine(greet.Sayhello("BALRAJ"));
            Console.WriteLine("Hello, World!");
            Console.WriteLine("TUESDAY\t");
            Console.WriteLine("Monday");
            Maths math = new Maths();
            Console.WriteLine(math.AddTwoNos(1, 2));


            
        }
    }
}
