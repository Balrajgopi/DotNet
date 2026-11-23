using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    internal class Pens
    {
        public String? Color { get; set; }
        public int Price { get; set; }

        public static List<Pens> penList = new List<Pens>();


        public static void Main(string[] args)
        {
            CreatePenList(penList);
            ReadPenList(penList);
            FoundPen("Blue");
        }
        private static void ReadPenList(List<Pens> penList)
        {
            foreach (Pens p in penList)
            {
                Console.WriteLine($"Color : {p.Color}, Price : {p.Price}");
            }
        }

        private static void CreatePenList(List<Pens> penList)
        {
            penList.Add(new Pens { Color = "Red", Price = 140 });
            penList.Add(new Pens { Color = "Blue", Price = 1000 });
            penList.Add(new Pens { Color = "Pink", Price = 10 });
            penList.Add(new Pens { Color = "Black", Price = 150 });
        }

        private static void FoundPen(String color)
        {

            foreach (Pens p in penList)
            {
                if (p.Color == color)
                  Console.WriteLine($"Found Pen Color : {p.Color}, Price : {p.Price}");
            }
        }
    }

}
