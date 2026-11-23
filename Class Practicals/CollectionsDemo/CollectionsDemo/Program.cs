using System.Collections;
using System.Runtime.InteropServices;

namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arraylist = new ArrayList(); // for creating arraylist that can conatins anything like  class, object
            arraylist.Add(20);
            arraylist.Add("Tom"); // using Add we can add the object, class in array list 
            arraylist.Add(new Pen { Color = "Red", Price = 100 });

            for (int i = 0; i < arraylist.Count; i++ )
            {
                if (arraylist[i] is int) // is used for the checking the Arraylist
                {
                    int n = Convert.ToInt32(arraylist[i]);
                    Console.WriteLine($"{n * n}");
                }
                else if (arraylist[i] is string)
                {
                    string s = Convert.ToString(arraylist[i]);
                    Console.WriteLine($"Hello {s}");
                }
                else if (arraylist[i] is Pen)
                {
                    Pen p = (Pen)arraylist[i];
                    Console.WriteLine($"Color : {p.Color}, Price : {p.Price}");
                    // Console.WriteLine(arraylist[i]);
                }
            }

        }
    }

    class Pen
    {
        public string? Color { get; set; }
        public int Price { get; set; }

    }
}
