using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPsProblemSet1_Inheritance
{
    internal class Robot : ITalkable, IWalkable
    {
        public string RobotName { get; set; }
        public string RobotModel { get; set; }

        public Robot(string robotname,string robotmodel)
        {
            RobotName = robotname;
            RobotModel = robotmodel;
        }
        public string Walk()
        {
            return $"*  {RobotName} Model {RobotModel} is walking.";
        }

        public string Talk()
        {
            return $"*  {RobotName} Model {RobotModel} is talking.";
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the Robot Name: ");
            string robotname = Console.ReadLine();

            Console.Write("Enter the Robot Model: ");
            string robotmodel = Console.ReadLine();

            Robot R1 = new Robot(robotname,robotmodel);

            Console.WriteLine(R1.Walk());
            Console.WriteLine(R1.Talk());

        }

       
    }
}