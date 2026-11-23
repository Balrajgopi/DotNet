using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsProblemSet1_Inheritance
{
    internal class Payment
    {
      //  public string[] PaymentArray = new string[] { "Credit Card", "UPI", "Cash" };

        public virtual string ProcessPayment()
        {
            return $"* Processing payment\n\n";
        }

    }

    internal class CreditCardPayment : Payment
    {

        public override string ProcessPayment()
        {
            return $"Processing credit card payment ........ {base.ProcessPayment()}";
            //base.ProcessPayment();
        }
    }

    internal class UpiPayment : Payment
    {
        public override string ProcessPayment()
        {
            return $"Processing UPI payment ........ {base.ProcessPayment()}";
            //base.ProcessPayment();
        }
    }

    internal class CashPayment : Payment
    {
        public override string ProcessPayment()
        {
            return $"Processing cash payment ........ {base.ProcessPayment()}";
            //base.ProcessPayment();
        }
    }

    internal class PaymentTest
    {
        static void Main(string[] args)
        {
            //// Payment P1 = new Payment();
            // Payment P2 = new CreditCardPayment();
            // Payment P3 = new UpiPayment();
            // Payment P4 = new CashPayment();


            // PaymentPrint(P2);
            // PaymentPrint(P3);
            // PaymentPrint(P4);
            // //PaymentPrint(P1);

            Payment[] payments = new Payment[] { new CreditCardPayment(), new UpiPayment(), new CashPayment() };

            foreach(Payment payment in payments)
            {
                PaymentPrint(payment);
            }
        }

        public static void PaymentPrint(Payment payment)
        {
            Console.WriteLine(payment.ProcessPayment());
        }
    }
}

    