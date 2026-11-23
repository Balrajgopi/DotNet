using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_ProblemSet
{
    internal class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public double AccountBalance { get; set; }

        public string GetAccountDetails()
        {
            return $"* Account HolderName : {AccountHolderName} \n* Account Number : {AccountNumber}  \n* Account Balance :{AccountBalance}";
        }
    }
}
