using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Management_System
{
    internal interface IBank
    {
        public abstract void Deposit(double Amount);
        public abstract void Withdraw(double Amount);

    }
}

