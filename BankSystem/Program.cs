using System;
using System.IO.Compression;
using System.Runtime.CompilerServices;

namespace BankSystem
{
    public class BankActions()
    {
        private double balance = 40.00;
        private int pinNumber = 1234;
        private int pinAuthCounter = 0;
        public bool accAuth = false;

        // public BankActions()
        // {
        //     // balance = 40.00;
        //     // pinNumber = 1234;
        // }

        public void Withdraw()
        {

        }
        public void Deposit()
        {

        }
        public void View()
        {
            Console.WriteLine($"Account balance: ${balance}");
        }

        public void PIN()
        {
            while (pinAuthCounter != 5)
            {
                Console.Write("Enter your PIN number: ");
                int pinAuth = Convert.ToInt32(Console.ReadLine());
                if (pinAuth == pinNumber)
                {
                    Console.WriteLine("PIN identified.");
                    accAuth = true;
                    break;
                }
                else if (pinAuthCounter == 4)
                {
                    Console.WriteLine("You have reached the maximum number of attempts. Please try again.");
                    accAuth = false;
                    break;
                }
                else
                {
                    pinAuthCounter++;
                    Console.WriteLine("Error. Incorrect pin. Try again");
                }
            }
        }

    }


    class Program
    {
        public static void Main(string[] args)
        {
            BankActions Acc1 = new BankActions();
            Acc1.PIN();
            bool Acc1Authen = Acc1.accAuth;
            if (Acc1Authen == true)
            {
                Acc1.View();
            }

        }
    }

    

}