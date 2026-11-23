using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class TestGeneries
    {
        public static void Main(string[]args)
        {
           // int a = 10; int b = 20;
           // Console.WriteLine($"A = {a}, B = {b}");
           //// Swap( a,  b); // if we call by variable so its dont give the logiced data its will give the current data like a  = 10 b = 20
           // Console.WriteLine($"A = {a}, B = {b}");
           // Swap(ref a,ref b);
           // Console.WriteLine($"A = {a}, B = {b}");
            string s1 = "Hello", s2 = "Balraj";
            NewSwap<string>(ref s1, ref s2);

            Console.WriteLine($"A = {s1}, B = {s2}");
        }

        //public static void Swap( int a, int b)
        //{
        //    int temp;
        //    temp = a;
        //    a = b;
        //    b = temp;
        //}

        //public static void Swap (ref int a, ref int b)
        //{
        //    int temp;
        //    temp = a;
        //    a = b;
        //    b = temp;
        //}

        public static void NewSwap<T>(ref T a, ref T b) // this will swap any type of data and this T is called as Generies type where we have T can anything when what the user is given value ;  and ref is called as refernce its  used to give the refernce of the object  
        {
            T temp = a;
            a = b;
            b = temp;

        }
    }
}
