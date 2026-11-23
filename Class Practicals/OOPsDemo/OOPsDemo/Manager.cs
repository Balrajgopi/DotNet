using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
     internal class Manager:Employee
    {
        public int Da { get; set; }
        public int Hra { get; set; }

        //public Manager(int id , string name, int salary, string dept, int da, int hra)
        //    //: base(id,name,salary,dept)
        //{
        //    base.Id = id;
        //    base.Name = name;   
        //    Da = da;
        //    Hra = hra;
        //}

        public string GetManagerDetails()
        {
            return $"Managers Details : * Id : {base.Id}    * Name : {base.Name}    * Salary : Rs.{base.Salary}.00    * Dept : {Dept}    * Da : {Da}    * Hra : {Hra}";
        }

        public override string CalculateSalary()
        {
            int managerSalary = Salary + Da + Hra;
            return $"Manager Salary: Rs.{managerSalary}.00";
        }

        //public override int CalculateSalary()
        //{
        //    return Da;
        //} this is created by me
    }
}
