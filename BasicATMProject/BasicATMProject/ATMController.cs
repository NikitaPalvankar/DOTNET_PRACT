using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicATMProject
{
    internal class ATMController
    {
        private Account _account;
        public ATMController(Account account)
        {
            this._account = account;
        }
        internal void showMenu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("\n **************** Welcome to ATM Application ****************");
                Console.WriteLine("1. Check Account balance \n2. Deposit");
                Console.WriteLine("3. Withdraw \n4. Exit ");
                Console.WriteLine("Enter your choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                double amount;
                bool status;
                switch (choice)
                {
                    //1. Check Account balance
                    case 1:
                        Console.WriteLine("Your account balance is : " + _account.getBalance());
                        break;

                    //2. Deposit
                    case 2:
                        Console.WriteLine("Enter the amount you want to deposit: ");
                        amount = Convert.ToDouble(Console.ReadLine());
                        status = _account.deposit(amount);
                        if (status)
                        {
                            Console.WriteLine("Your {0} amount deposited sucessfully.", amount);
                            Console.WriteLine("Your account balance is : " + _account.getBalance());
                        }
                        else
                            Console.WriteLine("Not added.");

                        break;

                    //3.Withdraw
                    case 3:
                        Console.WriteLine("Enter the amount you want to withdraw: ");
                        amount = Convert.ToDouble(Console.ReadLine());
                        status = _account.withdraw(amount);
                        if (status)
                        {
                            Console.WriteLine("Your {0} amount withdraw sucessfully.", amount);
                            Console.WriteLine("Your account balance is : " + _account.getBalance());
                        }
                        else
                            Console.WriteLine("Insufficient Balance. Please check your account balance.");

                        break;

                    //Exit
                    case 4:
                        Console.WriteLine("ThankYou for visiting.");
                        break;

                }


            } while (choice != 4);
        }
    }
}
