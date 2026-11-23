using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Management_System
{
    internal class SavingAccount : BankAccount
    {
        //public int AccountNumber { get; set; }
        //public string? AccountHolderName { get; set; }
        //public double InitialBalance = 500;

        public SavingAccount (int accountnumber, string accountholder, double balance) : base( accountnumber,  accountholder,  balance)
        {
        }

        public override void Deposit()
        {

            Console.Write($"\nEnter Amount For Deposit in Account Number {AccountNumber} :");
            double Amount = Convert.ToDouble(Console.ReadLine());

            if (Amount <= 0)
            {
                Console.WriteLine("Amount Should Be More Than Rs.0\n");
            }
            else
            {
                //InitialBalance += Amount;

                Console.WriteLine($"SuccesFully Rs.{Amount}.00 Desposit \n Current Balance : Rs.{InitialBalance += Amount}.00\n");
            }
        }

        public override void Withdraw()
        {

            Console.Write($"\nEnter Amount For WithDrawal in Account Number {AccountNumber} :");
            int Amount = Convert.ToInt32(Console.ReadLine());

            if (Amount <= 0)
            {
                Console.WriteLine($"\nAmount Should Be More Than Rs.0 \n* Current Balance : {InitialBalance}\n");
            }
            else if (InitialBalance - Amount < 500)
            {
                Console.WriteLine($"Minimum Balance Should Be 500 Can't Withdraw \n * Your Current Balance Rs.{InitialBalance}.00\n");

            }else
            {
                // InitialBalance -= Amount;

                Console.WriteLine($"SuccesFully Rs.{Amount}.00 Withdrawal \n * Current Balance : Rs.{InitialBalance -= Amount}.00\n");
            }
        }

        //public override void DisplayAccount()
        //{
        //    Console.WriteLine($" AccountNumber : {AccountNumber} Account HolderName : {AccountHolderName} \n");
        //}

        public override void DisplayBalance()
        {
            Console.WriteLine($"\n * AccountNumber : {AccountNumber} * Account HolderName : {AccountHolderName} * Account Balance : Rs.{InitialBalance}.00 \n");
        }
    }
}
