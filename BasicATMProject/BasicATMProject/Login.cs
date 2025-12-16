using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicATMProject
{
    internal class Login
    {
        String pin = "20072001";
        int Max_attempts = 3;

        public bool authenticate()
        {
            int attempts =0;
           
            do
            {
                attempts++;
                Console.WriteLine("Plese Enter your pin: ");
                String uPin = Console.ReadLine();
               
                if(uPin == pin)
                {
                    
                    return true;
                }
                else
                {
                    Console.WriteLine("You have entered Wrong Pin. Please enter correct pin.");
                }
            }
            while (attempts <= Max_attempts);



            return false;
        }



    }
}
