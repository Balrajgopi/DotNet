using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
    internal abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Dept { get; set; }

        public abstract string CalculateSalary();

        //public Employee(int id, string name, int salary, string dept)
        //{
        //    Id = id;
        //    Name = name;
        //    Salary = salary;
        //    Dept = dept;
        //}

        public String GetDetails()
        {
            return $"* Id : {Id}    * Name: {Name}    * Salary: {Salary}    * Dept: {Dept}";
        }
    }
}
