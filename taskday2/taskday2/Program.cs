using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskday2
{
    internal class Program
    { class BankSystem
        {
            private int AccountNumber;
            private string AccountHolderName;
            private double Balance;
            private string AccountType;
            private bool IsActive;
            public BankSystem(int AN, string name , double B, string ACT, bool IA)
            {
                AccountNumber = AN;
                AccountHolderName = name;
                Balance = B;
                AccountType = ACT;
                IsActive = IA;
            }

            public int AN
            {
                get { return AccountNumber;}
                set { AccountNumber = value;}

            }
            public string AHN
            {
                get { return AccountHolderName; }
                set { AccountHolderName = value; }

            }
            public double BALANCE
            {
                get { return Balance; }
                set { Balance = value; }

            }
            public string AT
            {
                get { return AccountType; }
                set { AccountType = value; }

            }
            public bool ISACTIVE
            {
                get { return IsActive; }
                set { IsActive = value; }

            }
            public void CheckBalance()
            {   if (Balance == 0)
                {
                    Console.WriteLine("you can not Withdraw cause your account does not enough ");
                }
                else if (Balance > 0)
                {
                    Console.WriteLine("your accont with balance =" + Balance);
                }
                else
                {
                    Console.WriteLine("Error in your acount");
                }
               
            }
            public void Deposit(double amount)
            {  if (amount > 1)
                {
                    Balance += amount;
                    Console.WriteLine("Amount deposited successfully\n");
                }
                else
                {
                    Console.WriteLine("Amount deposited insufficient you must deposited more than 1 JD\n");
                }

            }
            public void Withdraw(double amount)
            {   if (!IsActive)
                { Console.WriteLine("Account is not active"); }
                
                else if (amount <= Balance & amount >= 5 & Balance > 0)
                {
                    Balance = Balance - amount;
                    Console.WriteLine("Amount Withdraw successfully\n");
                }
                else
                { Console.WriteLine("Insufficient balance\n"); }
            }
          
            public void printInfo()
            {
                Console.WriteLine("Account Number: " + AN);
                Console.WriteLine("Name: " + AHN);
                Console.WriteLine("Account Type: " + AT);
                Console.WriteLine("Balance: " + BALANCE);
                Console.WriteLine("Active: " + ISACTIVE);
                Console.WriteLine("------------------");
            }
            ~BankSystem()
            {
                Console.WriteLine("Delete\n");
            }

        }
        static void Main(string[] args)
        {
            BankSystem b1 = new BankSystem(123,"yara",3500,"account",true);
            b1.Deposit(100);
            b1.Withdraw(50);
            b1.CheckBalance();
            b1.printInfo();

            BankSystem b2 = new BankSystem(321, "jood ", 5550, "account", true);
            b2.Deposit(100);
            b2.Withdraw(50);
            b2.CheckBalance();
            b2.printInfo();
            BankSystem b3 = new BankSystem(222, "lama", 6000, "account", false);
            b3.Deposit(100);
            b3.Withdraw(50);
            b3.CheckBalance();
            b3.printInfo();
            BankSystem b4 = new BankSystem(333, "noor", 0, "account", true);
            //b4.Deposit(100);
            b4.Withdraw(50);
            b4.CheckBalance();
            b4.printInfo();
            BankSystem b5 = new BankSystem(444, "mohammad",5, "account", true);
            b5.Deposit(0);
            b5.Withdraw(50);
            b5.CheckBalance();
            b5.printInfo();

        }
    }
}
