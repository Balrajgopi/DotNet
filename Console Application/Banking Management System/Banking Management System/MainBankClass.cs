//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace Banking_Management_System
//{
//    internal class MainBankClass
//    {
//        static BankAccount account;

//        public static void CreateAccount()
//        {
//            Console.WriteLine("Press 1: Create Saving Account");
//            Console.WriteLine("Press 2: Create Current Account");

//            int choice = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("Enter Account Number:");
//            int number = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("Enter Initial Balance:");
//            double balance = Convert.ToDouble(Console.ReadLine());

//            Console.WriteLine("Enter Account Holder Name:");
//            string? name = Console.ReadLine();

//            if (choice == 1)
//            {
//                account = new SavingAccount(number, name, balance);
//                Console.WriteLine("Saving Account Created Successfully!");
//            }
//            else if (choice == 2)
//            {
//                account = new CurrentAccount(number, name, balance);
//                Console.WriteLine("Current Account Created Successfully!");
//            }
//            else
//            {
//                Console.WriteLine("Invalid Account Type!");
//            }
//        }

//        public static void DisplayDeposit()
//        {
//            if (account == null)
//            {
//                Console.WriteLine("Please Create Account First!");
//                return;
//            }

//            account.Deposit();
//        }

//        public static void DisplayWithdrawal()
//        {
//            if (account == null)
//            {
//                Console.WriteLine("Please Create Account First!");
//                return;
//            }

//            account.Withdraw();
//        }

//        public static void DisplayAccount()
//        {
//            if (account == null)
//            {
//                Console.WriteLine("Please Create Account First!");
//                return;
//            }

//            account.DisplayBalance();
//        }

//        static void Main(string[] args)
//        {
//            int input;

//            do
//            {
//                Console.WriteLine("\n========== BANK MENU ==========");
//                Console.WriteLine("Press 1: Create Account");
//                Console.WriteLine("Press 2: Deposit Amount");
//                Console.WriteLine("Press 3: Withdraw Amount");
//                Console.WriteLine("Press 4: View Account Information");
//                Console.WriteLine("Press 5: Exit");

//                Console.WriteLine("Enter Your Choice:");
//                input = Convert.ToInt32(Console.ReadLine());

//                switch (input)
//                {
//                    case 1:
//                        CreateAccount();
//                        break;

//                    case 2:
//                        DisplayDeposit();
//                        break;

//                    case 3:
//                        DisplayWithdrawal();
//                        break;

//                    case 4:
//                        DisplayAccount();
//                        break;

//                    case 5:
//                        Console.WriteLine("Exiting Program...");
//                        break;

//                    default:
//                        Console.WriteLine("Invalid Choice!");
//                        break;
//                }

//            } while (input != 5);
//        }
//    }
//}

