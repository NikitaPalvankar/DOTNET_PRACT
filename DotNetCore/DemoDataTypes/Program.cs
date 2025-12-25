namespace DemoDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region datatypes
            ////datatypes 
            //int a = 1;
            //System.Int32 b = 2;
            //double d = 3.14;
            //Console.WriteLine("a = {0}, b={1}, d ={2}", a , b , d);

            //String str = "Namaste";
            //String str1 = "Hello from Pune";
            //String str2 = new string("abcd");
            //Console.WriteLine(str+" "+ str1);
            //char ch = 'a';

            //char[] chArr = new char[2];
            //chArr[0] = 'H';
            //chArr[1] = 'I';

            //String str4 = new String(chArr); 
            #endregion


            #region If-else
            //bool isEven = true;
            //if (isEven)
            //{
            //    Console.WriteLine("Number is Even number");
            //}
            //else
            //{
            //    Console.WriteLine("Number is Odd numbra");
            //}
            #endregion

            #region for loop
            //for (int i = 1; i <= 10; i++)
            //{

            //    Console.WriteLine(2*i);
            //}
            #endregion

            #region while
            //int x = 5;
            //while (x > 0)
            //{
            //    Console.WriteLine(x);
            //    x--;
            //}
            #endregion

            #region do-while
            //int x = 10;
            //do
            //{
            //    Console.WriteLine(x);
            //    x-=2;
            //} while (x > 0);
            #endregion

            #region switch-case
            //Console.WriteLine("Enter your choice");
            //string input = Console.ReadLine();
            //int choice = Convert.ToInt32(input);

            //switch(choice)
            //{
            //    case 1:
            //        Console.WriteLine("You selected option 1");
            //        break;
            //    case 2:
            //        Console.WriteLine("You selected option 2");
            //        break;
            //    case 3:
            //        Console.WriteLine("You selected option 3");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid option selected");
            //        break;
            //}
            #endregion

            #region Boxing and Unboxing and Type-casting
            #region Boxing
            //int x = 100; // Value Type
            //string str = "Hello World"; // Reference Type
            //Object obj1 = new object(); // Reference Type
            //// Boxing: Converting Value Type to Reference Type
            //obj1 = x;
            //Console.WriteLine(obj1);
            //str = Convert.ToString(x);// Boxing
            //string str2 = x.ToString();// Boxing 
            #endregion

            #region Unboxing:
            //// Unboxing: Converting Reference Type back to Value Type
            //int y = Convert.ToInt32(obj1); // Unboxing
            //int p = Convert.ToInt32(str2); // Unboxing
            //Console.WriteLine("Y ={0}, P ={1}",y,p);
            #endregion


            #region Type-casting
            //double d = 9.18;
            //int num1 =Convert.ToInt32(d); // Implicit Type-casting 
            //double d2 = num1; // Explicit Type-casting
            //Console.WriteLine("d = {0}, num1 = {1}, d2 ={2}",d,num1,d2);

            //object obj2 = new object();
            //string str4 = "Someting";
            //obj2 = str4; // Implicit Type-casting
            //string str5 = obj2.ToString(); // Explicit Type-casting

            #endregion

            #endregion
        }
    }
}
