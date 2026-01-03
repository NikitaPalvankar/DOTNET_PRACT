namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- MENU ---");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Create User");
                Console.WriteLine("3. Forgot Password");
                Console.WriteLine("4. Exit");
                Console.Write("Choose option: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: Login(); break;
                    case 2: CreateUser(); break;
                    case 3: ForgotPassword(); break;
                    case 4: return;
                    default: Console.WriteLine("Invalid choice"); break;
                }
            }

        }
    }
}
