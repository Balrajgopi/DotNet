using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPsProblemSet1_Inheritance
{
    internal class Calculator
    {
        public void Add()
        {
            Console.WriteLine(" *   Addition of Multiple numbers Using Same Method Name - Method OverLoading *\n");
        }

        public void  Add(int a)
        {

            Console.WriteLine($"Addition of {a} With 5 is : {a + 5}\n");
        }
        
        public void Add(int a, int b)
        {
            //Console.Write($"Enter 2 numbers: ");
            Console.WriteLine($"Addition of {a} With {b} is : {a + b}\n");
        }

        public void Add(int a, int b, int c)
        {
            Console.WriteLine($"Addition of {a} With {b} With {c} is : {a + b + c}\n");
        }

        public void Add(int a, int b, int c, int d)
        {
           
            Console.WriteLine($"Addition of {a} With {b} With {c} With {d} is : {a + b + c + d}\n");
        }

        static void Main (string[]args)
        {
            Calculator C1 = new Calculator();
            C1.Add();
            C1.Add(10);
            C1.Add(10, 20);
            C1.Add(10, 20, 30);
            C1.Add(10, 20, 30, 40);

            Calculator C2 = new Calculator();   
            C2.Add();   
            C2.Add(100);
            C2.Add(100, 200);
            C2.Add(100, 200, 300, 400);
            C2.Add(100, 200, 300);

            Calculator C3 = new Calculator();   
            C3.Add();   
            C3.Add(1000);
            C3.Add(1000, 2000);
            C3.Add(1000, 2000, 3000);
            C3.Add(1000, 2000, 3000, 4000);

        }

    }
    
}
