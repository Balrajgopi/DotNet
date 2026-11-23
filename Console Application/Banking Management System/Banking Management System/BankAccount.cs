using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Management_System
{
    internal abstract class BankAccount
    {
        public int AccountNumber { get; set; }
        public string? AccountHolderName { get; set; }
        public double InitialBalance { get; set; }

        public BankAccount(int accountnumber, string accountholder, double balance)
        {
            AccountNumber = accountnumber;
            AccountHolderName = accountholder;
            InitialBalance = balance;
        }
        public abstract void Deposit();
        public abstract void Withdraw();
        public abstract void DisplayBalance();
    }
}
