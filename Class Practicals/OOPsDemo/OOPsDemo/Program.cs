namespace OOPsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(" * Calling Pen Class Private Properities in Main Class \n");

            Console.WriteLine($"Total pen created : {Pen.getpenCount()}\n");

            Pen Penobject = new Pen();

            Penobject.Color = "pink";

            Console.WriteLine($"Color : {Penobject.Color}\n");

            Console.WriteLine(Penobject.getdetails());

            Pen P1 = new Pen("Red",200);
            Pen P2 = new Pen("Pink",250);

            P2.Color = "Black";
            P2.Price = -200;
            Console.WriteLine($"Color of Pen of By deflut : {P1.Color}\n");
            
            Console.WriteLine($"Color of Pen : {P2.Color}\n");

            Console.WriteLine(P2.getdetails());

            Pen[] Parray = new Pen[3];

            Parray[0] = new Pen("Dark Green",-300);
            Parray[1] = new Pen("Dark Blue", 100);
            Parray[2] = new Pen("Dark Pink", 900);

            foreach (Pen pen in Parray)
            {
                Console.WriteLine(pen.getdetails());
            }


            Pen[] pens = new Pen[3];

            for (int i = 0; i < pens.Length; i++)
            {
                Console.Write($"Enter the Color of Pen : {i + 1 }");
                string color = Console.ReadLine();

                Console.Write($"Enter the Price of Pen : {i + 1}");
                int price = Convert.ToInt32(Console.ReadLine());
                pens[i] = new Pen( color,price);
            }

            foreach (Pen pen in pens)
            {
                Console.WriteLine(pen.getdetails());
            }

            Console.WriteLine($"Total pen created : {Pen.getpenCount()}");





            



















        }
    }
}
