using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
    internal class Sales:Employee
    {
        public int Commission { get; set; }
        public int OT { get; set; }

        //public Sales (int id , string name , int salary, string dept, int commission, int ot)
        //    //:base(id,name,salary,dept)
        //{
        //    Commission = commission;
        //    OT = ot;
        //}

        public string GetSalesDetails()
        {
            return $"Sales Details Id : {base.Id}    * Name : {Name}    * Salary : Rs.{Salary}.00    * Dept : {Dept}    * Commision : {Commission}    * OT : {OT}";
        }

        public override string  CalculateSalary()
        {
            return $"Total Sales: Rs.{Salary + OT + Commission}.00";
        }
    }
}
