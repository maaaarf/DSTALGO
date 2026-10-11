// Digital Bank Account Manager
// Create a bank account class with private attributes -- CHECK
// accountNumber, accountHolder, balance -- CHECK
//
// Implement public methods
// deposit(), withdraw(), getBalance() -- CHECK
//
// Add business rules validation
// No negative deposits -- CHECK
// No withdrawals exceeding the balance -- CHECK
// Instantiate multiple distinct BankAccount object in your Main program
// -> Perform transactions, print account summaries across different accounts

using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

namespace BankAccountManager
{

    
    class Bank
    {
        // private string accountHolder;
        private int accountNumber { get; set; }
        private double balance { get; set; } = 0;
        public int index = -1;
        

        // public Bank(int size)
        // {
        //     withdrawHistory = new double[size];
        // }

        public void Balance() // checks current balance
        {
            Console.WriteLine($"Balance: ${balance}");
        }
        public void Withdraw(double money) // withdraws from balance
        {
            if (money < balance)
            {
                balance -= money;
                Console.WriteLine($"You have withdrawn {money} from your account");
                // withdrawHistory[++index] = money;
            }
            else
            {
                Console.WriteLine("You do not have enough money in yo account");
            }
        }
        public void Deposit(double money) // deposits to balance
        {
            if (money <= 0)
            {
                Console.WriteLine("You cannot deposit an amount less than $1");
            }
            else
            {
                balance += money;
                Console.WriteLine($"You have deposited: ${money}");
            }
        }

        // public void CheckWithdHistory()
        // {
        //     Console.WriteLine(withdrawHistory[0]);
        // }
    }

    class Program()
    {
        // public static double[] withdrawHistory;
        static void Main(string[] args)
        {
            
            Bank Marf = new Bank();
            Bank Enzo = new Bank();

            // Console.Write("How much do you want to deposit?: ");
            // double depositAmount = Convert.ToDouble(Console.ReadLine());

            // Marf.Deposit(depositAmount);
            // Marf.Balance();

            // Console.Write("How much do you want to withdraw?: ");
            // double withdrawAmount = Convert.ToDouble(Console.ReadLine());

            // Marf.Withdraw(withdrawAmount);
            // Marf.Balance();

            bool loopChecker = true;
            while (loopChecker)
            {
                Console.WriteLine("Welcome to Definitely Not Bank of The Philippines");
                // Console.WriteLine("1. Deposit\n2. Withdraw\n3. Check Balance\n4. Check withdrawal history\n5. Exit");
                Console.WriteLine("1. Deposit\n2. Withdraw\n3. Check Balance\n4. Exit");
                Console.Write(">>> ");
                int choices = Convert.ToInt32(Console.ReadLine());

                switch (choices)
                {
                    case 1:
                        Console.WriteLine("Depositing to account Marf");
                        Console.Write("How much do you want to deposit?: ");
                        double depositAmount = Convert.ToDouble(Console.ReadLine());
                        Marf.Deposit(depositAmount);
                    break;

                    case 2:
                        Console.WriteLine("Withdrawing from account Marf");
                        Console.Write("How much do you want to withdraw?: ");
                        double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                        Marf.Withdraw(withdrawAmount);
                    break;

                    case 3:
                        Console.WriteLine("Checking balance of account Marf");
                        Marf.Balance();
                        
                    break;

                    // case 4: 
                    //     Console.WriteLine("Checking withdrawal history");
                    //     // Marf.CheckWithdHistory();
                    // break;

                    case 4:
                    loopChecker = false;
                    break;
                }
            }
        }
    }
}
