using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_ProblemSet
{
    internal class Rectangle
    {
        public int Length { get; set; }
        public int Width { get; set; }


        public int Area()
        {
            return Length * Width;
        }

        public int Perimeter()
        {
            return 2 * (Length + Width);
        }

        public String GetDetails()
        {
            
            return $"* Length = {Length}, * Width = {Width}, \n\n* Area Of Rectangle : {Area()} \n\n* Perimeter Of Rectangle : {Perimeter()}";
        }

    }
}
