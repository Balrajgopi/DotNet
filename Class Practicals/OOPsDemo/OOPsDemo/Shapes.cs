using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
//                                 * RunTime Ploymorphism In C# *
namespace OOPsDemo
{
    internal  class Shapes
    {
        public virtual void Area()
        {
            Console.Write("* Area Of Shapes ");
        }
        
    }
    internal class Circle:Shapes
    {
        public int Radius { get; set; }

        public override void Area()
        {
            double area = Math.PI * Radius * Radius;
            Console.WriteLine($"Circle is : {area}");
        }
    }
    internal class Rectangle : Shapes
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public override void Area()
        {
            double area = Length * Width;
            Console.WriteLine($"Rectangle is : {area}");
        }
    }

    internal class TestShapes
    {
        static void Main(string[] args)
        {
            //Shapes S0 = new Shapes();
            //            S0.Area();

            //Circle C1 = new Circle { Radius = 4 };
            //            S0.Area ();
            //            C1.Area();
            //Shapes S1 = new Circle { Radius = 5 };
            //            S1.Area();
            //            S0.Area();

            //Rectangle R1 = new Rectangle { Length = 2, Width = 5 };
            //            R1.Area();

            //Shapes S2 = new Rectangle { Length=5 , Width=10 };
            //            S2.Area();

            //RunTime Ploymorphism Concept In C#

            Shapes S0 = new Shapes();
            Shapes S1 = new Circle { Radius = 5 };
            Shapes S2 = new Rectangle { Length = 5, Width = 10 };
            CalculateArea(S0);
            CalculateArea(S1);
            CalculateArea(S0);
            CalculateArea(S2);
        }
            public static void CalculateArea(Shapes shape)
            {
                shape.Area();
            }
        

        }
    }

