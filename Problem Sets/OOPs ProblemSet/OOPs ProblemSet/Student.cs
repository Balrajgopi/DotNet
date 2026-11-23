using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_ProblemSet
{
    internal class Student
    {
        private int RollNo;
        private string Name;
        private float Marks;

        public int rollno { get { return RollNo; } set { RollNo = value; } }
        public string name { get { return Name; } set { Name = value; } }
        public float marks { get { return Marks; } set { Marks = value; } }

        public Student(string name, int rollno, float marks)
        {
            this.Name = name;
            this.RollNo = rollno;
            this.Marks = marks;
        }

        public string GetDetails()
        {
            return $" * Student Name : {name}, Student RollNumber : {this.rollno}, Student Marks : {marks}\n";
        }

        public string GetGrade()
        {
            if (marks <= 40)
                return $"* Student Name : {name}, Student RollNumber : {rollno}, Student Marks : {marks}, Student Grade : F\n";

            else 
                return $"* Student Name : {name}, Student RollNumber : {rollno}, Student Marks : {marks}, Student Grade : A\n";
        }
       
    }
}
