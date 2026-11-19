namespace DemoLanguage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 21;
            string name = "Balraj";
            float Salary = 5000f;
            DateTime today = DateTime.Now;
            string end = "....<3";
            string bye = "          Bye";
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age = {0}", age);
            Console.WriteLine($"Salary = ${Salary}");
            Console.WriteLine($"Today = {today:dd-MM-yyyy}");
            Console.WriteLine($"Today = {today:F}");
            Console.Write(bye);
            Console.WriteLine(end);
           
        }
    }
}
