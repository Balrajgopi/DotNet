using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet
{
    internal class Problem10
    {
        static void Main ()
        {
            double Balance = 1000;
            int Deposit = 500;
            int Withdrawal = 250;

            Console.WriteLine($"Current Balance : {Balance}");

            Balance += Deposit;
            Console.WriteLine($"Balance After Deposit Of {Deposit}: {Balance}");

            Balance -= Withdrawal;
            Console.WriteLine($"Balance After WithDrawal Of {Withdrawal} : {Balance}");

            Console.WriteLine($"* Final Balance : {Balance}");
        }
    }
}
