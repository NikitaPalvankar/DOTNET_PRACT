using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicATMProject
{
    internal class Account
    {
        double balance = 0;

        public Account(double amount) {
            this.balance = amount;
        }

        //Get initial balance
        public double getBalance() { 
            return balance;
        }
        //deposite mehtod
        public bool deposit(double amount) { 
            
            balance += amount;
            return true;
        }

        //withdraw method
        public bool withdraw(double amount)
        {
            if (balance < 0 || balance < amount)
                return false;
            else
                balance -= amount;
                return true;
        }
    }
}
