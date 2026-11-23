using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOPsProblemSet1_Inheritance.Fan;

namespace OOPsProblemSet1_Inheritance
{
    internal abstract class Problem16Appliance
    {
        protected  string  Brand;

        public abstract string TurnOn();
        public string GetBrand()
        {
            return Brand;
        }
    }

    internal class Fan : Problem16Appliance
    {
        public Fan(string brand)
        {
            Brand = brand;
        }
        public override string TurnOn()
        {
            return $"{Brand} is TurnedOn";
        }

    internal class WashingMachine : Problem16Appliance
        {
            public WashingMachine(string brand)
            {
                Brand = brand;
            }

            public override string TurnOn()
            {
                return $"{Brand} is TurnedOn";
            }
        }
    }

    internal class ApplianceTest
    {
        static void Main(string[]args)
        {
            Problem16Appliance[] A1 = new Problem16Appliance[] { new Fan("Gopi Fan"), new WashingMachine("Gupta's WashingMachine") };

            static void AppliancePrint (Problem16Appliance A1)
            {
                Console.WriteLine(A1.TurnOn());
            }

            foreach(Problem16Appliance Appliance in A1)
            {
                AppliancePrint(Appliance);
            }
        }
    }
}
