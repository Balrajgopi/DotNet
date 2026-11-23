//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection.Metadata.Ecma335;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPsProblemSet1_Inheritance
//{
//    internal sealed class TaxCalculator
//    {
//         public int Sgst;
//        public int Cgst;

//        public int CalculateTax (int sgst, int cgst)
//        {
//            return sgst + cgst;
//        }
//    }

//    internal class DrivedTaxCal : TaxCalculator
//    {
//        static void Main(string[]args)
//        {
//            DrivedTaxCal tc = new DrivedTaxCal();
//            tc.CalculateTax(2,3);
//            Console.WriteLine(tc);
//        }
//    }
//}
