namespace DemoDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //datatypes 
            int a = 1;
            System.Int32 b = 2;
            double d = 3.14;
            Console.WriteLine(a + b + d);

            String str = "Namaste";
            String str1 = "Hello from Pune";
            String str2 = new string("abcd");
            char ch = 'a';
            
            char[] chArr = new char[2];
            chArr[0] = 'H';
            chArr[1] = 'I';

            String str4 = new String(chArr);
            


        }
    }
}
