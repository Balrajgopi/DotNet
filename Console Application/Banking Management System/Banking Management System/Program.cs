using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Banking_Management_System
{
    internal class Program 
    {
        static BankAccount account;


        public static void CreateAccount()
        {

            Console.WriteLine("\nEnter 1 : To Create Saving Account ");
            Console.WriteLine("\nEnter 2 : To Create Current Account ");
            Console.Write("\nEnter : ");
            int Acc = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n===== * Enter Details for Creating Saving Account * =====");

            Console.Write("\nEnter Account Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Enter Initial Balnce : ");
            double balance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Enter Name Of the Account Holder : ");
            string? name = Console.ReadLine();

            if (Acc == 1)
            {
                account = new SavingAccount(number, name, balance);
            }
            else if (Acc == 2)
            {
                account = new CurrentAccount(number, name, balance);
            }
            else 
            {
                Console.WriteLine("Invalid Account Type!");
            }
        }

        public static void DisplayDeposit()
        {
            account.Deposit();
        }

        public static void DisplayWithdrawal()
        {
            account.Withdraw();
        }

        public static void DisplayAccount()
        { 
            account.DisplayBalance();
        }

        static void Main(string[] args)
        {


            int Input;
            do
            {
                Console.WriteLine("\n========== * MENU * ==========\n");
                Console.WriteLine("Enter 1 : To Create Account ");
                Console.WriteLine("Enter 2 : To Despoit Amount ");
                Console.WriteLine("Enter 3 : To Withdraw Amount ");
                Console.WriteLine("Enter 4 : To View Acoount Info ");
                Console.WriteLine("Enter 5 : Exit\n");
                Console.Write("Enter : ");
                Input = Convert.ToInt32(Console.ReadLine());

                switch (Input)
                {
                    case 1:
                        CreateAccount();
                        break;

                    case 2:
                        DisplayDeposit();
                        break;

                    case 3:
                        DisplayWithdrawal();
                        break;

                    case 4: DisplayAccount();
                        break;

                    case 5:
                        Console.WriteLine("Exiting.... Program");
                        break;
                }
            }
            while (Input != 5);
        }
    }
}


