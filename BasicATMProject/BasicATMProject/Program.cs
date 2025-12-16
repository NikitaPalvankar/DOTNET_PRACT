namespace BasicATMProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MyHelloWorld
            // Console.WriteLine("Hello, World!");
            #endregion

            #region MyNameFromConsole
            //Console.WriteLine("Enter your name: ");
            //String name = Console.ReadLine();

            //Console.WriteLine("Hello, This is {0} ", name);
            #endregion

            #region Login
            //Login l1 = new Login();
            //bool status = l1.authenticate();
            //if (status)
            //    Console.WriteLine("Logged in Successfully");
            //else
            //    Console.WriteLine("Too many attempts. Your acc is locked.");

            #endregion

            #region ATMMenu
            Login l1 = new Login();
            bool status = l1.authenticate();
            if (status)
            {
                Console.WriteLine("Logged in Successfully");
                Account acc = new Account(2000.00);
                ATMController aController = new ATMController(acc);
                
                aController.showMenu();

            }
            else
                Console.WriteLine("Too many attempts. Your acc is locked.");

            #endregion


        }
    }
}
