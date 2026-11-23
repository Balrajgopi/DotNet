using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_ProblemSet
{
    internal class Product
    {

        public int Price { get; set; }
        public string ProductName { get; set; }

        public Product ( string productName, int price )
        {
            this.Price = price;
            this.ProductName = productName;
        }
    }
}  


