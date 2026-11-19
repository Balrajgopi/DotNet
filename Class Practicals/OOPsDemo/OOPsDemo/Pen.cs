using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
    internal class Pen
    {
        static int penCount = 0;

        public static int getpenCount() 
        {
            return penCount++;
        }
        private string color;
        private int price;


        public string Color
        {
            get { return color.ToLower(); }
            set { color = value; }
        }
      //  public string x = ("Enter Value Above 0");

        public int Price
        { 
            get { return price; }
            set
            { 
                if ( value >= 0)
                {
                    price = value;
                }
                //else
                //{
                //    return ;
                //}
            }
        }

        public Pen()
        {
            penCount++;
            this.color = "Blue";
            this.price = 100;

        }

        public Pen (string color, int price)
        {
            penCount++;
            this.color = color;
            this.price = price;
        }

        public string getdetails ()
        {
            return ($"Color : {color}, Price {price}");
        }

        static Pen ()
        {
            Console.WriteLine("This is the Static Construction");
        }
    }
}
