using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsProblemSet1_Inheritance
{
    internal class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double EmpSalary { get; set; }

        public double CalculateAnnualSalary()
        {
            return EmpSalary * 12;
        }


    }

    internal class Manager : Employee
    {
        public int TeamSize { get; set; }

        public Manager(int empId, string empName, double empSalary, int teamSize)
        {
            EmpId = empId;
            EmpName = empName;
            EmpSalary = empSalary;
            TeamSize = teamSize;
        }

        public void DisplayManagerDetails()
        {
            Console.WriteLine($"Manager ID: {EmpId}");
            Console.WriteLine($"Manager Name: {EmpName}");
            Console.WriteLine($"Manager Salary: {EmpSalary}");
            Console.WriteLine($"Team Size: {TeamSize}");
            Console.WriteLine($"Manager Annual Salary : {CalculateAnnualSalary()}");
        }

        internal class Display
        {
            static void Main(string[]args)
            {
                Manager M1 = new Manager(101, "Ankit Bhai", 5000, 4);
                M1.DisplayManagerDetails();

                Manager M2 = new Manager(102,"Balraj Gopi",5000,14);
                M2.DisplayManagerDetails();
            }
        }
    }
}
