namespace OOPs_ProblemSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                 * Problem 1 : Book Class *\n"); 

            Book B1 = new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Price = 1000 };
            Book B2 = new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", Price = 1500 };

            Console.WriteLine($" * Book 1 -> Title = {B1.Title} Author = {B1.Author} Price = Rs{B1.Price}\n");
           // Console.WriteLine("\n---------------------------------------------------------------------------------\n");
            Console.WriteLine($" * Book 2 -> Title = {B2.Title} Author = {B2.Author} Price = Rs{B2.Price}");

            Console.WriteLine("\n\n                 * Problem 2 : Employee Class *\n");

            Employee E1 = new Employee { Name = "Balraj", Id = 1, Salary = 5000 };
            Employee E2 = new Employee { Name = "Mohit", Id = 2, Salary = 15000 };
            Employee E3 = new Employee { Name = "Rupesh", Id = 3, Salary = 25000 };

            Console.WriteLine($" * Employee ID : {E1.Id}, Employee Name : {E1.Name}, Employee Salary = {E1.Salary} \n");
            Console.WriteLine($" * Employee ID : {E2.Id}, Employee Name : {E2.Name}, Employee Salary = {E2.Salary} \n");
            Console.WriteLine($" * Employee ID : {E3.Id}, Employee Name : {E3.Name}, Employee Salary = {E3.Salary} \n");

            Console.WriteLine("\n\n                 * Rectangle Details *\n");

            Rectangle R1 = new Rectangle();

            Console.Write($"* Enter Length Of The Rectangle : ");
            R1.Length = Convert.ToInt32(Console.ReadLine());

            Console.Write($"* Enter Width Of The Rectangle : ");
            R1.Width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine(R1.GetDetails());







        }
    }
}
