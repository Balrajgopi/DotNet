//using System.Drawing;

//namespace ListDemo
//{
//    internal class Program
//    {
//        class Pen
//        {
//            public string? Color { get; set; }

//            public int Price { get; set; }

//        }
//        public static List<Pen> penList = new List<Pen>();

//        static void Main(string[] args)
//        {
//            CreatePenList();
//            AReadPenList();

//            // to Create a List we can use List<DataType> Object = new List<DataType>();

//            List<int> list = new List<int>();
//            list.Add(10);
//            list.Add(20);
//            list.Add(30);

//            for (int i = 0; i < list.Count; i++)
//            {
//                Console.WriteLine(list[i]);
//                // list.Add(60);
//                //break;
//                //Console.WriteLine(list[i]);
//            }


//            List<Pen> P1 = new List<Pen>();

//            P1.Add(new Pen { Color = "Red", Price = 100 });
//            P1.Add(new Pen { Color = "Black", Price = 200 });
//            P1.Add(new Pen { Color = "Blue", Price = 400 });
//            P1.Add(new Pen { Color = "Purple", Price = 300 });
//            P1.Add(new Pen { Color = "Green", Price = 6600 });
//            P1.Add(new Pen { Color = "White", Price = 700 });
//        // when we use the foreach the syntax is 
//        // foreach (DataType Object in P1("Which U have Sreach or Print")  )
          
//            foreach (Pen P in P1)
//            {
//                Console.WriteLine($" * Color Of Pen is : {P.Color}\n * Price Of The Pen is : {P.Price}");
//            }
//            Console.WriteLine("\n");

//            P1.RemoveAt(4);

//            foreach (Pen P in P1)
//            {
//                //Console.WriteLine(P1[P]); IF USING CLASS AS CONSTRUCTOR ALWAYS CALL THE OBJECT WITH THE VARIABLE LIKE P.COLOR NOT AS P1[P]
//                Console.WriteLine($"Color : {P.Color}, Price : {P.Price} ");
//            }      
         

//        }

     

        
       

     
//    }
    
//}
