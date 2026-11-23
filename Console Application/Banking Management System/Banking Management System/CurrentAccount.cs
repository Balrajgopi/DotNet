using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Management_System
{
    internal class CurrentAccount : SavingAccount
    {
        
        public CurrentAccount(int accountnumber, string accountholder, double balance) : base( accountnumber,  accountholder,  balance)
        {

        }

        public override void Deposit()
        {
            Console.WriteLine($"\nEnter Amount For Deposit in Account Number {AccountNumber} :");
            int Amount = Convert.ToInt32(Console.ReadLine());

            if (Amount == 0)
            {
                Console.WriteLine("\n ERROR : Amount Should Be More Than Rs.0");
            }
            else
            {
                //InitialBalance += Amount;

                Console.WriteLine($"SuccesFully Rs.{Amount}.00 Desposit \n * Current Balance : Rs.{InitialBalance += Amount}.00\n");
            }
        }

        public override void Withdraw()
        {
            // if (InitialBalance <= 500)
            // {
            //     Console.WriteLine($"ERROR : Minimum Balance Should Be 500 Can't Withdraw Your Current Balance Rs.{InitialBalance}.00");
            // }
            // else
            // {
            // InitialBalance -= Amount;

            Console.Write($"\nEnter Amount For Deposit in Account Number {AccountNumber} :");
            int Amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"SuccesFully Rs{Amount}.00 Withdrawal \n * Current Balance : Rs.{InitialBalance -= Amount}.00\n");
            //}
        }

        //public override void DisplayAccount()
        //{
        //    Console.WriteLine($" AccountNumber : {AccountNumber} Account HolderName : {AccountHolderName} \n");
        //}

        public override void DisplayBalance()
        {
            Console.WriteLine($" AccountNumber : {AccountNumber} Account HolderName : {AccountHolderName} Account Balance : Rs.{InitialBalance}.00 \n ");
        }
    }
}
